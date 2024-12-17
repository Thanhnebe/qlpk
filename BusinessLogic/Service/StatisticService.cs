using DataAccess;
using DataAccess.Repository;
using System;

namespace BusinessLogic.Service
{
    public class StatisticService
    {
        private PaymentRepository paymentRepository = new PaymentRepository();
        private TreatmentRequestRepository treatmentRequestRepository = new TreatmentRequestRepository();
        private HealthcareFacilityDetailRepository healthcareFacilityDetailRepository = new HealthcareFacilityDetailRepository();
        private DiseaseDetailRepository diseaseDetailRepository = new DiseaseDetailRepository();
        private MedicineDetailRepository medicineDetailRepository = new MedicineDetailRepository();

        public decimal FindTotalPaymentAmountInRange(DateTime from, DateTime to)
        {
            return paymentRepository.FindTotalPaymentAmountInRange(from, to);
        }

        public long FindTotalOfPatientInRange(DateTime from, DateTime to)
        {
            return treatmentRequestRepository.FindTreatmentRequestCountInRange(from, to);
        }

        public HealthcareFacility FindTheMostUsedHealthcareFacilityInRange(DateTime from, DateTime to)
        {
            return healthcareFacilityDetailRepository.FindMostUsedHealthcareFacilityInRange(from, to);
        }

        public Disease FindTheMostDiseaseInRange(DateTime from, DateTime to)
        {
            return diseaseDetailRepository.FindMostDiseaseInRange(from, to);
        }

        public Medicine FindTheMostUsedMedicineInRange(DateTime from, DateTime to)
        {
            return medicineDetailRepository.FindMostUsedMedicineInRange(from, to);
        }

    }
}
