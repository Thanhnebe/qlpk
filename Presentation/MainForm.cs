using ClinicManagement.ClinicForm;
using System;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPatientManagement_Click(object sender, EventArgs e)
        {
            new PatientForm().ShowDialog(this);
        }

        private void btnDoctorManagement_Click(object sender, EventArgs e)
        {
            new DoctorForm().ShowDialog(this);
        }

        private void btnMedicineManagement_Click(object sender, EventArgs e)
        {
            new MedicineForm().ShowDialog(this);
        }

        private void btnHealthFacilityManagement_Click(object sender, EventArgs e)
        {
            new HealthcareFacilityForm().ShowDialog(this);
        }

        private void btnTreatmentRequestManagement_Click(object sender, EventArgs e)
        {
            new TreatmentRequestForm().ShowDialog(this);
        }

        private void btnStatisticManagement_Click(object sender, EventArgs e)
        {
            new StatisticForm().ShowDialog(this);
        }

        private void btnDiseaseManagement_Click(object sender, EventArgs e)
        {
            new DiseaseForm().ShowDialog(this);
        }

    }
}
