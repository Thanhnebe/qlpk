using System;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class MedicineRepository : User<Medicine>
    {
        protected override Expression<Func<Medicine, bool>> GetSearchAnythingExpression(string searchText)
        {
            return t => t.MedicineName.ToLower().Contains(searchText) ||
                        t.Usage.Contains(searchText);
        }

    }
}
