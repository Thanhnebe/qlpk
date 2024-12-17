using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repository
{
    public class PaymentRepository : User<Payment>
    {
        public List<Payment> FindByTreatmentRequestId(long treatmentRequestId)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.Payments.Where(p => p.TreatmentRequestId == treatmentRequestId).ToList();
            });
        }

        public bool ExistByTreatmentRequestId(long treatmentRequestId)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.Payments.Any(p => p.TreatmentRequestId == treatmentRequestId);
            });
        }

        public decimal FindTotalPaymentAmountInRange(DateTime from, DateTime to)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.Payments
                                .Where(p => p.PayDate >= from && p.PayDate <= to)
                                .Select(p => p.AmountMoney)
                                .DefaultIfEmpty(0)
                                .Sum();
            });
        }

    }
}
