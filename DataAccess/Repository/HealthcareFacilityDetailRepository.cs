using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repository
{
    public class HealthcareFacilityDetailRepository : User<HealthcareFacilityDetail>
    {

        public override List<HealthcareFacilityDetail> FindAll()
        {
            return FindAllWithInclude("HealthcareFacility");
        }

        public List<HealthcareFacilityDetail> FindByTreatmentRequestId(long treatmentRequestId)
        {
            return CallInContext(dbContext =>
            {
                return dbContext.HealthcareFacilityDetails
                                .Where(h => h.TreatmentRequestId == treatmentRequestId)
                                .Include("HealthcareFacility")
                                .ToList();
            });
        }

        public HealthcareFacility FindMostUsedHealthcareFacilityInRange(DateTime from, DateTime to)
        {
            return CallInContext(dbContext =>
            {
                long? mostUsedHealthcareFacilityId = dbContext.HealthcareFacilityDetails
                                                              .Where(d => d.RegisterDate >= from && d.RegisterDate <= to)
                                                              .GroupBy(m => m.HealthcareFacilityId)
                                                              .Select(d => new { HealthcareFacilityId = d.Key, Count = d.Count() })
                                                              .OrderByDescending(d => d.Count)
                                                              .Select(h => (long?)h.HealthcareFacilityId)
                                                              .FirstOrDefault();
                if (mostUsedHealthcareFacilityId.HasValue)
                {
                    return dbContext.HealthcareFacilities.Where(d => d.HealthcareFacilityId == mostUsedHealthcareFacilityId).First();
                }
                return null;
            });
        }

    }
}
