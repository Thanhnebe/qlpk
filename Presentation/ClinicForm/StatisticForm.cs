using BusinessLogic.Service;
using DataAccess;
using System;

namespace ClinicManagement.ClinicForm
{
    public partial class StatisticForm : System.Windows.Forms.Form
    {
        private StatisticService statisticService;

        public StatisticForm()
        {
            statisticService = new StatisticService();
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date + new TimeSpan(23, 59, 59);


            decimal totalPayment = statisticService.FindTotalPaymentAmountInRange(from, to);
            long totalPatients = statisticService.FindTotalOfPatientInRange(from, to);
            Disease mostDisease = statisticService.FindTheMostDiseaseInRange(from, to);
            Medicine mostUsedMedicine = statisticService.FindTheMostUsedMedicineInRange(from, to);
            HealthcareFacility mostUsedHealthcarefalictyName = statisticService.FindTheMostUsedHealthcareFacilityInRange(from, to);

            txtRevenue.Text = string.Format("{0:#,##0}", Decimal.Parse(totalPayment.ToString()));
            txtNumberOfPatient.Text = string.Format("{0:#,##0}", Decimal.Parse(totalPatients.ToString()));
            txtMostDiseaseName.Text = mostDisease == null ? "" : mostDisease.DiseaseName;
            txtMostUsedMedicineName.Text = mostUsedMedicine == null ? "" : mostUsedMedicine.MedicineName;
            txtMostUsedHealthcareFacilityName.Text = mostUsedHealthcarefalictyName == null ? "" : mostUsedHealthcarefalictyName.Name;
        }

    }
}
