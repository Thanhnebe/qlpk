
using DataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    public partial class PatientForm : ClinicCRUDBaseForm<Patient>
    {

        public PatientForm() : base()
        {
            InitializeComponent();
            ConfigClinicComponents();

            AddBindingControls(txtName, dtpBirthday, txtAddress, txtPhone, txtIdentityNumber);

            dataGridViewControl.CellClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                Patient patient = ((DataGridView)sender).Rows[e.RowIndex].DataBoundItem as Patient;
                rbtnMale.Checked = patient.Sex;
            };
        }

        protected override Patient CreateEntityFromBindingControls()
        {
            Patient patient = base.CreateEntityFromBindingControls();
            patient.Sex = rbtnMale.Checked;
            return patient;
        }

        protected override void ResetValue(List<Control> controls)
        {
            base.ResetValue(controls);
            rbtnMale.Checked = true;
        }

        private void AllowOnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            rbtnFemale.Checked = !rbtnMale.Checked;
        }

    }

}
