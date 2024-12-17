
using DataAccess;
using System;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    public partial class DoctorForm : ClinicCRUDBaseForm<Doctor>
    {
        public DoctorForm(): base()
        {
            InitializeComponent();
            ConfigClinicComponents();
            AddBindingControls(txtName, dtpBirthday, txtAddress, txtPhone, txtIdentityNumber, cbDegree, txtMajor);

            dataGridViewControl.CellClick += (object sender, DataGridViewCellEventArgs e) =>
            {
                if (e.RowIndex < 0)
                {
                    return;
                }

                Doctor doctor = ((DataGridView)sender).Rows[e.RowIndex].DataBoundItem as Doctor;
                rbtnMale.Checked = doctor.Sex;
            };
        }

        protected override Doctor CreateEntityFromBindingControls()
        {
            Doctor doctor = base.CreateEntityFromBindingControls();
            doctor.Sex = rbtnMale.Checked;
            return doctor;
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
