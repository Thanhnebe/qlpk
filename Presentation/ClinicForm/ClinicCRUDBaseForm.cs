using BusinessLogic.Service;
using DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    public class ClinicCRUDBaseForm<E> : Form where E : class
    {
        delegate T Consumer<T>();

        protected IClinicService<E> service;

        protected TextBox txtSearchControl;
        protected Button btnSearchControl;
        protected Button btnRefreshControl;
        protected Button btnAddControl;
        protected Button btnUpdateControl;
        protected Button btnDeleteControl;
        protected DataGridView dataGridViewControl;

        protected Dictionary<string, Control> bindingControlDictionary;
        protected Dictionary<string, object> bindingControlDataSourceDictionary;

        protected string[] primaryKeyNames;

        public ClinicCRUDBaseForm()
        {
            bindingControlDictionary = new Dictionary<string, Control>();
            bindingControlDataSourceDictionary = new Dictionary<string, object>();

            InjectServices();
            AddLoadEventHandler();
        }

        private void InjectServices()
        {
            Assembly assembly = Assembly.Load("BusinessLogic");
            string serviceClassName = "BusinessLogic.Service." + GetType().Name.Replace("Form", "") + "Service";
            Type serviceType = assembly.GetType(serviceClassName);
            if (serviceType != null)
            {
                service = (ClinicBaseService<E>)Activator.CreateInstance(assembly.GetType(serviceClassName));
            }
        }

        protected void ConfigClinicComponents()
        {
            AutoMapCRUDControls(this);
            ConfigGridViewData();
            AddEventHandlerToCRUDButton();
        }

        protected void AddLoadEventHandler()
        {
            this.Load += (object sender, EventArgs e) =>
            {
                if (DesignMode)
                {
                    return;
                }
                primaryKeyNames = EntityUtils.GetPrimaryKeyNames(typeof(E));
                LoadDataToDataGridView();
                LoadDataToBindingControls();
            };
        }

        #region Setting GridViewData
        protected void LoadDataToDataGridView()
        {
            LoadDataToGridView(service.FindAll());
        }

        protected void LoadDataToGridView(List<E> entities)
        {
            dataGridViewControl.DataSource = entities;
            ResetValue(bindingControlDictionary.Values.ToList());
        }

        protected void ConfigGridViewData()
        {
            dataGridViewControl.AutoGenerateColumns = false;

            foreach(DataGridViewColumn column in dataGridViewControl.Columns)
            {

                if (column.Name.EndsWith("Id") || column.Name.EndsWith("Price") || column.Name.EndsWith("Quantity"))
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            dataGridViewControl.CellClick += (sender, e) =>
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                DataGridView dgv = (DataGridView)sender;
                Object selectedEntity = dgv.Rows[e.RowIndex].DataBoundItem;

                foreach (var item in bindingControlDictionary)
                {
                    SetValueToControl(item.Value, selectedEntity.GetType().GetProperty(item.Key).GetValue(selectedEntity));
                }
            };

            dataGridViewControl.DataBindingComplete += (sender, e) =>
            {
                dataGridViewControl.ClearSelection();
            };

            dataGridViewControl.CellFormatting += (sender, e) =>
            {
                DataGridViewColumn column = dataGridViewControl.Columns[e.ColumnIndex];
                if (column.DataPropertyName.Contains("."))
                {
                    object data = dataGridViewControl.Rows[e.RowIndex].DataBoundItem;
                    string[] properties = column.DataPropertyName.Split('.');
                    for (int i = 0; i < properties.Length && data != null; i++)
                    {
                        data = data.GetType().GetProperty(properties[i]).GetValue(data);
                    }
                    dataGridViewControl.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
                }

                string columName = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
                if (columName.EndsWith("dgvcSex"))
                {
                    e.Value = (bool)e.Value ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }

                if (columName.EndsWith("Price") || columName.EndsWith("Quantity"))
                {
                    e.Value = String.Format("{0:#,##0.##}", e.Value);
                    e.FormattingApplied = true;
                }

            };
        }
        #endregion

        #region Setting binding controls
        protected void LoadDataToBindingControls()
        {
            foreach (var item in bindingControlDataSourceDictionary)
            {
                Control control = bindingControlDictionary[item.Key];
                if (control.GetType() != typeof(ComboBox))
                {
                    continue;
                }

                ComboBox comboBox = (ComboBox)control;
                comboBox.DataSource = item.Value;
                comboBox.ValueMember = item.Key;

                comboBox.Format += (sender, e) =>
                {
                    object obj = e.ListItem;
                    string id = obj.GetType().GetProperty(item.Key).GetValue(obj).ToString();
                    string name = obj.GetType().GetProperties().ToList().First(p => p.Name.EndsWith("Name")).GetValue(obj).ToString();
                    e.Value = string.Format("{0} - {1}", name, id);
                };
            }
        }

        protected virtual E CreateEntityFromBindingControls()
        {
            E entity = Activator.CreateInstance<E>();

            foreach (var item in bindingControlDictionary)
            {
                PropertyInfo pi = entity.GetType().GetProperty(item.Key);
                object value = GetValueFromControl(item.Value);
                if (pi.PropertyType == typeof(int))
                {
                    value = int.Parse(value.ToString());
                }
                else if (pi.PropertyType == typeof(long))
                {
                    value = long.Parse(value.ToString());
                }
                pi.SetValue(entity, value);
            }

            return entity;
        }

        private void MapToCRUDControl(Control control)
        {
            if (control.Name.StartsWith("btn"))
            {
                if (control.Name.EndsWith("Add"))
                {
                    btnAddControl = (Button)control;
                }
                else if (control.Name.EndsWith("Update"))
                {
                    btnUpdateControl = (Button)control;
                }
                else if (control.Name.EndsWith("Delete"))
                {
                    btnDeleteControl = (Button)control;
                }
                else if (control.Name.EndsWith("Search"))
                {
                    btnSearchControl = (Button)control;
                }
                else if (control.Name.EndsWith("Refresh"))
                {
                    btnRefreshControl = (Button)control;
                }
            }

            if (control.Name.StartsWith("txt") && control.Name.EndsWith("Search"))
            {
                txtSearchControl = (TextBox)control;
            }

            if (control.GetType() == typeof(DataGridView))
            {

                dataGridViewControl = (DataGridView)control;
            }
        }

        protected void AutoMapCRUDControls(Control root)
        {
            Stack<Control> stack = new Stack<Control>();
            stack.Push(root);

            do
            {
                var control = stack.Pop();

                foreach (Control child in control.Controls)
                {
                    MapToCRUDControl(child);
                    stack.Push(child);
                }
            }
            while (stack.Count > 0);
        }

        protected void AddBindingFieldControl(string fieldName, Control control)
        {
            bindingControlDictionary.Add(fieldName, control);
            control.Tag = fieldName;
        }

        protected void AddBindingControl(string fieldName, Control control, object dataSource)
        {
            AddBindingFieldControl(fieldName, control);
            bindingControlDataSourceDictionary.Add(fieldName, dataSource);
        }

        protected void AddBindingControls(params Control[] controls)
        {
            foreach (var control in controls)
            {
                char firstUpperChar = control.Name.FirstOrDefault(c => Char.IsUpper(c));
                int firstUpperCharIdx = control.Name.IndexOf(firstUpperChar);
                string fieldName = control.Name.Substring(firstUpperCharIdx, control.Name.Length - firstUpperCharIdx);
                AddBindingFieldControl(fieldName, control);
            }
        }

        private void SetValueToControl(Control control, object value)
        {
            Dictionary<Type, Action> dic = new Dictionary<Type, Action>()
            {
                { typeof(TextBox),        () => { ((TextBox)control).Text         = value.ToString(); }},
                { typeof(RichTextBox),    () => { ((RichTextBox)control).Text     = value.ToString(); }},
                { typeof(NumericUpDown),  () => {
                    ((NumericUpDown)control).Value = value.GetType() == typeof(decimal) ? decimal.Parse(value.ToString()) : long.Parse(value.ToString());
                }},
                { typeof(DateTimePicker), () => { ((DateTimePicker)control).Value = (DateTime)value; }},
                { typeof(ComboBox),       () => {
                    ComboBox cbx = (ComboBox)control;
                    if (value.GetType() == typeof(string))
                    {
                        cbx.SelectedIndex = cbx.FindStringExact(value.ToString());
                    }
                    else
                    {
                        cbx.SelectedValue = value;
                    }
                }},
            };

            if (dic.ContainsKey(control.GetType()))
            {
                dic[control.GetType()].Invoke();
            }
        }

        private object GetValueFromControl(Control control)
        {
            Dictionary<Type, Consumer<object>> dic = new Dictionary<Type, Consumer<object>>()
            {
                { typeof(TextBox),        () => ((TextBox)control).Text.Trim() },
                { typeof(RichTextBox),    () => ((RichTextBox)control).Text.Trim() },
                { typeof(NumericUpDown),  () => ((NumericUpDown)control).Value },
                { typeof(DateTimePicker), () => ((DateTimePicker)control).Value },
                { typeof(ComboBox),       () => {
                    ComboBox cbx = (ComboBox)control;
                    if (cbx.SelectedIndex < 0)
                    {
                        throw new Exception("Lựa chọn(combobox) bị rỗng.");
                    }
                    if (cbx.SelectedItem.GetType() == typeof(string))
                    {
                        return ((ComboBox)control).SelectedItem;
                    }
                    return cbx.SelectedValue;
                }}
            };

            if (dic.ContainsKey(control.GetType()))
            {
                return dic[control.GetType()].Invoke();
            }

            return control.Text;
        }

        protected virtual void ResetValue(List<Control> controls)
        {
            Dictionary<Type, Action<Control>> dic = new Dictionary<Type, Action<Control>>()
            {
                { typeof(TextBox),        (control) => { ((TextBox) control).Text          = string.Empty; } },
                { typeof(RichTextBox),    (control) => { ((RichTextBox) control).Text      = string.Empty; } },
                { typeof(NumericUpDown),  (control) => { ((NumericUpDown)control).Value    = 0; } },
                { typeof(DateTimePicker), (control) => { ((DateTimePicker)control).Value   = DateTime.Now; } },
                { typeof(ComboBox),       (control) => { ((ComboBox)control).SelectedIndex = -1; } }
            };

            controls.ForEach(control =>
            {
                if (dic.ContainsKey(control.GetType()))
                {
                    dic[control.GetType()].Invoke(control);
                }
            });
        }

        #endregion

        #region Setting CRUD buttons event handler
        protected virtual void AddEventHandlerToCRUDButton()
        {
            btnAddControl.Click += AddEventHandler;
            btnUpdateControl.Click += UpdateEventHandler;
            btnDeleteControl.Click += DeleteEventHandler;

            if (btnSearchControl != null)
            {
                btnSearchControl.Click += SearchEventHandler;
            }

            btnRefreshControl.Click += RefreshEventHandler;
        }

        protected void ValidateSelectedRowInDataGridView()
        {
            if (dataGridViewControl.SelectedRows.Count <= 0)
            {
                throw new Exception("Bạn chưa chọn đối tượng.");
            }
        }

        protected virtual void AddEventHandler(object sender, EventArgs e)
        {
            try
            {
                E entity = CreateEntityFromBindingControls();
                service.Add(entity);
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void UpdateEventHandler(object sender, EventArgs e)
        {
            try
            {
                ValidateSelectedRowInDataGridView();

                E entity = dataGridViewControl.SelectedRows[0].DataBoundItem as E;
                E updatedEntity = CreateEntityFromBindingControls();

                primaryKeyNames.ToList().ForEach(primaryKeyName =>
                {
                    object entityPrimaryValue = entity.GetType()
                                                      .GetProperty(primaryKeyName)
                                                      .GetValue(entity);
                    updatedEntity.GetType()
                                .GetProperty(primaryKeyName)
                                .SetValue(updatedEntity, entityPrimaryValue);
                });


                service.Update(updatedEntity);
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void DeleteEventHandler(object sender, EventArgs e)
        {
            try
            {
                ValidateSelectedRowInDataGridView();
                E entity = dataGridViewControl.SelectedRows[0].DataBoundItem as E;
                service.Delete(EntityUtils.GetValuesFromEntityByProperties(entity, primaryKeyNames));
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void SearchEventHandler(object sender, EventArgs e)
        {
            try
            {
                List<E> entities = service.FindByFuzzy(txtSearchControl.Text);
                LoadDataToGridView(entities);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        protected void RefreshEventHandler(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
        #endregion

    }
}
