
using DataAccess;
using System.Windows.Forms;

namespace ClinicManagement.ClinicForm
{
    public partial class DiseaseForm : ClinicCRUDBaseForm<Disease>
    {

        public DiseaseForm()
        {
            InitializeComponent();
            ConfigClinicComponents();
            AddBindingControls(txtDiseaseName);
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
