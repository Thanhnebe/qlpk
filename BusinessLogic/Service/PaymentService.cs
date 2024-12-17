using BusinessLogic.DTO;
using DataAccess;
using DataAccess.Repository;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Utils;

namespace BusinessLogic.Service
{
    public class PaymentService : ClinicBaseService<Payment>
    {
        private PaymentRepository paymentRepository = new PaymentRepository();
        private MedicineDetailRepository medicineDetailRepository = new MedicineDetailRepository();
        private HealthcareFacilityDetailRepository healthcareFacilityDetailRepository = new HealthcareFacilityDetailRepository();

        public List<Payment> FindByTreatmentRequestId(long treatmentRequestId)
        {
            return paymentRepository.FindByTreatmentRequestId(treatmentRequestId);
        }

        protected override void ValidateEntity(Payment payment)
        {
            ClinicExceptionUtils.throwIllegalExpcetionIfINull("Ngày thanh toán", payment.PayDate);
            ClinicExceptionUtils.throwIllegalExceptionIfNumberValueLessThan("Số tiền thanh toán", payment.AmountMoney, 1);
        }

        public bool ExistByTreatmentRequestId(long treatmentRequestId)
        {
            return paymentRepository.ExistByTreatmentRequestId(treatmentRequestId);
        }

        public List<BillItem> GetBillByTreamentRequestId(long treatmentRequestId)
        {
            List<HealthcareFacilityDetail> healthcareFacilityDetails = healthcareFacilityDetailRepository.FindByTreatmentRequestId(treatmentRequestId);
            List<MedicineDetail> medicineDetails = medicineDetailRepository.FindByTreatmentRequestId(treatmentRequestId);

            List<BillItem> billItems = new List<BillItem>(healthcareFacilityDetails.Count + medicineDetails.Count);
            foreach (var detail in healthcareFacilityDetails)
            {
                billItems.Add(new BillItem() { 
                    name = detail.HealthcareFacility.Name, 
                    quantity = detail.Quantity, 
                    price = detail.Price, 
                    totalAmount = detail.Quantity * detail.Price
                });
            }

            foreach (var detail in medicineDetails)
            {
                billItems.Add(new BillItem()
                {
                    name = detail.Medicine.MedicineName,
                    quantity = detail.Quantity,
                    price = detail.Price,
                    totalAmount = detail.Quantity * detail.Price
                });
            }

            return billItems;
        }

        public bool IsPayed(long treatmentRequestId)
        {
            List<BillItem> billItems = GetBillByTreamentRequestId(treatmentRequestId);
            List<Payment> payments = FindByTreatmentRequestId(treatmentRequestId);

            decimal amountTotal = billItems.Sum(b => b.totalAmount);
            decimal payed = payments.Sum(p => p.AmountMoney);
            return payments.Count > 0 && payed == amountTotal;
        }

    }
}
