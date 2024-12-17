using System;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class DoctorRepository : User<Doctor>
    {
        protected override Expression<Func<Doctor, bool>> GetSearchAnythingExpression(string searchText)
        {
            return d => d.Name.ToLower().Contains(searchText) ||
                        d.Phone.Contains(searchText) ||
                        d.Address.ToLower().Contains(searchText) ||
                        d.IdentityNumber.Contains(searchText) ||
                        d.Degree.Contains(searchText) ||
                        d.Major.Contains(searchText);
}

    }
}
