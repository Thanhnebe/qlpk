using System;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class HealthcareFacilityRepository : User<HealthcareFacility>
    {
        protected override Expression<Func<HealthcareFacility, bool>> GetSearchAnythingExpression(string searchText)
        {
            return b => b.Name.ToLower().Contains(searchText);
        }
    }
}
