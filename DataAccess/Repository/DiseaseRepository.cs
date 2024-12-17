using System;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class DiseaseRepository : User<Disease>
    {
        protected override Expression<Func<Disease, bool>> GetSearchAnythingExpression(string searchText)
        {
            return b => b.DiseaseName.ToLower().Contains(searchText);
        }

    }
}
