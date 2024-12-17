using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public interface IClinicRepository<E> where E : class
    {

        List<E> FindAll();

        List<E> FindAllWithInclude(params string[] includes);

        List<E> FindAllOrderByDES<R>(Expression<Func<E, R>> orderBy);

        E FindByIds(params object[] ids);

        void Add(E entity);

        void Update(E entity);

        void Delete(params object[] ids);

        bool ExistByIds(params object[] ids);

        List<E> FindByFuzzy(string searchText);

    }
}
