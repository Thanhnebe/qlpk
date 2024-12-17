
using DataAccess;

namespace ClinicManagement.ClinicForm
{
    public partial class MedicineForm : ClinicCRUDBaseForm<Medicine>
    {
        public MedicineForm()
        {
            InitializeComponent();
            ConfigClinicComponents();
            AddBindingControls(txtMedicineName, rtbUsage, cbUnit, nudQuantity, nudPrice);
        }

    }
}
