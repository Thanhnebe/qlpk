


using DataAccess;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    public partial class HealthcareFacilityForm : ClinicCRUDBaseForm<HealthcareFacility>
    {
        public HealthcareFacilityForm(): base()
        {
            InitializeComponent();
            ConfigClinicComponents();

            AddBindingControls(txtName, nudPrice);
        }

        private void AllowOnlyNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
