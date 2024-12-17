
using DataAccess;
using System;
using BusinessLogic.Service;

namespace ClinicManagement.ClinicForm
{
    public partial class MedicineDetailForm : ClinicCRUDCompositeForm<MedicineDetail>
    {
        private MedicineService medicineService;

        public MedicineDetailForm(long treatmentRequestId): base()
        {
            medicineService = new MedicineService();

            InitializeComponent();
            ConfigClinicComponents();

            AddBindingControl("MedicineId", cbMedicine, medicineService.FindAll());
            AddBindingControls(nudQuantity, nudPrice, rtbUsage);

            AddPermanentValueForEntity("TreatmentRequestId", treatmentRequestId);
        }

        private void cbMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medicine medicine = cbMedicine.SelectedItem as Medicine;
            if (medicine != null)
            {
                nudPrice.Value = medicine.Price;
            }
        }

    }
}
