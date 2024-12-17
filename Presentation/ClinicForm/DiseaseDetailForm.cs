
using DataAccess;
using BusinessLogic.Service;

namespace ClinicManagement.ClinicForm
{
    public partial class DiseaseDetailForm : ClinicCRUDCompositeForm<DiseaseDetail>
    { 
        private DiseaseService diseaseService;

        public DiseaseDetailForm(long treatmentRequestId): base()
        {
            diseaseService = new DiseaseService();

            InitializeComponent();
            ConfigClinicComponents();

            AddBindingControl("DiseaseId", cbDisease, diseaseService.FindAll());
            AddBindingControls(dtpTreatmentDate, rtbTreatmentMethod);

            AddPermanentValueForEntity("TreatmentRequestId", treatmentRequestId);
        }
    }

}
