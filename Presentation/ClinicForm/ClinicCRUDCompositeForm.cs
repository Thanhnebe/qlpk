
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    [DesignTimeVisible(false)]
    public class ClinicCRUDCompositeForm<E> : ClinicCRUDBaseForm<E> where E : class
    {
        protected Dictionary<string, object> permanentEntityValueDictionary;

        public ClinicCRUDCompositeForm(): base()
        {
            permanentEntityValueDictionary = new Dictionary<string, object>();
        }

        protected void AddPermanentValueForEntity(string propertyName, object propertyValue)
        {
            permanentEntityValueDictionary.Add(propertyName, propertyValue);
        }

        protected override E CreateEntityFromBindingControls()
        {
            E entity = base.CreateEntityFromBindingControls();

            if (permanentEntityValueDictionary != null)
            {
                foreach (var item in permanentEntityValueDictionary)
                {
                    entity.GetType()
                          .GetProperty(item.Key)
                          .SetValue(entity, item.Value);
                }
            }

            return entity;
        }

        protected override void UpdateEventHandler(object sender, EventArgs e)
        {
            try
            {
                ValidateSelectedRowInDataGridView();
                E oldEntity = dataGridViewControl.SelectedRows[0].DataBoundItem as E;
                E newEntity = CreateEntityFromBindingControls();

                service.Update(oldEntity, newEntity);
                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
