using System.Collections.Generic;

namespace BusinessLogic.Service
{
    public interface IClinicService<E> where E : class
    {

        List<E> FindAll();

        bool ExistByIds(params object[] ids);

        void Add(E entity);

        void Update(E entity);

        void Update(E oldEntity, E newEntity);

        void Delete(params object[] keys);

        List<E> FindByFuzzy(string searchText);

    }
}
