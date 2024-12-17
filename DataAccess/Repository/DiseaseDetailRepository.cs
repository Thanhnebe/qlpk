using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repository
{
    public class DiseaseDetailRepository : User<DiseaseDetail>
    {
        public override List<DiseaseDetail> FindAll()
        {
            return FindAllWithInclude("Disease");
        }

        public Disease FindMostDiseaseInRange(DateTime from, DateTime to)
        {
            return CallInContext(dbContext =>
            {
                long? mostDiseaseId = dbContext.DiseaseDetails
                                               .Where(d => d.TreatmentDate >= from && d.TreatmentDate <= to)
                                               .GroupBy(m => m.DiseaseId)
                                               .Select(d => new { DiseaseId = d.Key, Count = d.Count() })
                                               .OrderByDescending(d => d.Count)
                                               .Select(d => (long?)d.DiseaseId)
                                               .FirstOrDefault();
                if (mostDiseaseId.HasValue)
                {
                    return dbContext.Diseases.Where(d => d.DiseaseId == mostDiseaseId).First();
                }
                return null;
            });
        }

    }
}
