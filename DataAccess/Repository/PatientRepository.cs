using System;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public class PatientRepository : User<Patient>
    {
        protected override Expression<Func<Patient, bool>> GetSearchAnythingExpression(string searchText)
        {
            return p => p.Name.ToLower().Contains(searchText) ||
                        p.Phone.Contains(searchText) ||
                        p.Address.ToLower().Contains(searchText) ||
                        p.IdentityNumber.Contains(searchText);
        }
    }
}
