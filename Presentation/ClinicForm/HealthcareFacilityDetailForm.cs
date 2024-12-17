
using DataAccess;
using System;
using BusinessLogic.Service;

namespace ClinicManagement.ClinicForm
{
    public partial class HealthcareFacilityDetailForm : ClinicCRUDCompositeForm<HealthcareFacilityDetail>
    {
        private HealthcareFacilityService healthcareFacilityService;

        public HealthcareFacilityDetailForm(long treatmentRequestId)
        {
            healthcareFacilityService = new HealthcareFacilityService();

            InitializeComponent();
            ConfigClinicComponents();

            AddBindingControl("HealthcareFacilityId", cbHealthcareFacility, healthcareFacilityService.FindAll());
            AddBindingControls(nudQuantity, dtpRegisterDate, nudPrice, rtbNote);

            AddPermanentValueForEntity("TreatmentRequestId", treatmentRequestId);
        }

        private void cbHealthcareFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            HealthcareFacility hf = cbHealthcareFacility.SelectedItem as HealthcareFacility;
            if (hf != null)
            {
                nudPrice.Value = hf.Price;
            }
        }
    }
}
