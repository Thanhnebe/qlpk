using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class TreatmentRequestRepository : User<TreatmentRequest>
    {
        protected override Expression<Func<TreatmentRequest, bool>> GetSearchAnythingExpression(string searchText)
        {
            return p => p.Patient.Name.ToLower().Contains(searchText) ||
                        p.Doctor.Name.ToLower().Contains(searchText) ||
                        p.Note.Contains(searchText);
        }

        public override List<TreatmentRequest> FindAll()
        {
            return CallInContext(dbContext =>
            {
                return dbContext.TreatmentRequests
                                .OrderByDescending(t => t.RegisterDate)
                                .Include("Doctor")
                                .Include("Patient")
                                .ToList();
            });
        }

        public List<Payment> FindByTreatmentRequestId(long treatmentRequestId)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.Payments.Where(p => p.TreatmentRequestId == treatmentRequestId).ToList();
            });
        }

        public long FindTreatmentRequestCountInRange(DateTime from, DateTime to)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.TreatmentRequests
                                .Where(p => p.RegisterDate >= from && p.RegisterDate <= to)
                                .Count();
            });
        }

        public override List<TreatmentRequest> FindByFuzzy(string searchText)
        {
            return CallInContext(dbContext =>
            {
                return GetDbSet(dbContext)
                               .Where(GetSearchAnythingExpression(searchText.ToLower()))
                               .Select(p => p)
                               .Include("Doctor")
                               .Include("Patient")
                               .ToList();
            });
        }

    }
}
