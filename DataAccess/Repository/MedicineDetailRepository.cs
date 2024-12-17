using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repository
{
    public class MedicineDetailRepository : User<MedicineDetail>
    {
        public override List<MedicineDetail> FindAll()
        {
            return FindAllWithInclude("Medicine");
        }

        public List<MedicineDetail> FindByTreatmentRequestId(long treatmentRequestId)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.MedicineDetails
                                .Where(h => h.TreatmentRequestId == treatmentRequestId)
                                .Include("Medicine")
                                .ToList();
            });
        }

        public Medicine FindMostUsedMedicineInRange(DateTime from, DateTime to)
        {
            return CallInContext(dbContext =>
            {
                long? mostUsedMedicineId = dbContext.MedicineDetails
                                                    .Where(m => m.TreatmentRequest.RegisterDate >= from && m.TreatmentRequest.RegisterDate <= to)
                                                    .GroupBy(m => m.MedicineId)
                                                    .Select(m => new { MedicineId = m.Key, Count = m.Count() })
                                                    .OrderByDescending(m => m.Count)
                                                    .Select(m => (long?)m.MedicineId)
                                                    .FirstOrDefault();

                if (mostUsedMedicineId.HasValue)
                {
                    return dbContext.Medicines.Where(m => m.MedicineId == mostUsedMedicineId).First();
                }
                return null;
            });           
        }

    }
}
