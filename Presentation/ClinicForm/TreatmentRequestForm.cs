
using BusinessLogic.Service;
using ClinicManagement.ClinicForm;
using DataAccess;
using System;
using System.Windows;

namespace ClinicManagement.ClinicForm
{
    public partial class TreatmentRequestForm : ClinicCRUDBaseForm<TreatmentRequest>
    {
        private DoctorService doctorService;
        private PatientService patientService;

        public TreatmentRequestForm() : base()
        {
            doctorService = new DoctorService();
            patientService = new PatientService();

            InitializeComponent();
            ConfigClinicComponents();

            AddBindingControl("PatientId", cbPatient, patientService.FindAll());
            AddBindingControl("DoctorId", cbDoctor, doctorService.FindAll());

            AddBindingControls(dtpRegisterDate, rtbNote);
        }

        private long GetCurrentSelectedTreatmentId()
        {

                ValidateSelectedRowInDataGridView();
                return (dgvTreatmentRequest.SelectedRows[0].DataBoundItem as TreatmentRequest).TreatmentRequestId;

            
        }

        private void showCompositeFormAsDialog(Type formType)
        {
            try
            {
                System.Windows.Forms.Form form = (System.Windows.Forms.Form) Activator.CreateInstance(formType, new object[] { GetCurrentSelectedTreatmentId() });
                form.ShowDialog(this);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiseaseDetail_Click(object sender, EventArgs e)
        {
            showCompositeFormAsDialog(typeof(DiseaseDetailForm));
        }

        private void btnMedicalCare_Click(object sender, EventArgs e)
        {
            showCompositeFormAsDialog(typeof(HealthcareFacilityDetailForm));
        }

        private void btnMedicineDetail_Click(object sender, EventArgs e)
        {
            showCompositeFormAsDialog(typeof(MedicineDetailForm));
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            showCompositeFormAsDialog(typeof(PaymentForm));
        }
    }
}
