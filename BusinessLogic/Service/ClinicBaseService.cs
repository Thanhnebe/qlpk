using BusinessLogic.Exception;
using DataAccess.Repository;
using DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BusinessLogic.Service
{
    public abstract class ClinicBaseService<E> : IClinicService<E> where E : class
    {
        protected IClinicRepository<E> repository;

        public ClinicBaseService() {
            InjectRepository();
        }

        private void InjectRepository()
        {
            Assembly assembly = Assembly.Load("DataAccess");
            string repositoryClassName = "DataAccess.Repository." + GetType().Name.Replace("Service", "") + "Repository";
            repository = (User<E>)Activator.CreateInstance(assembly.GetType(repositoryClassName));
        }

        protected abstract void ValidateEntity(E entity);

        public List<E> FindAll()
        {
            return repository.FindAll();
        }

        public bool ExistByIds(params object[] ids)
        {
            return repository.ExistByIds(ids);
        }

        public void Add(E entity)
        {
            bool isExistEntity = repository.ExistByIds(EntityUtils.GetPrimaryKeyValues(entity));
            if (isExistEntity)
            {
                throw new ClinicEntityIllegalStateException("Đối tượng này đã tồn tại trong hệ thống.");
            }
            ValidateEntity(entity);
            repository.Add(entity);
        }

        public void Update(E entity)
        {
            bool isExistEntity = repository.ExistByIds(EntityUtils.GetPrimaryKeyValues(entity));
            if (!isExistEntity)
            {
                throw new ClinicEntityNotFoundException("Không tìm đối tượng cập nhật.");
            }
            ValidateEntity(entity);
            repository.Update(entity);
        }

        public void Update(E oldEntity, E newEntity)
        {
            object[] oldPrimaryValues = EntityUtils.GetPrimaryKeyValues(oldEntity);
            object[] newPrimaryValues = EntityUtils.GetPrimaryKeyValues(newEntity);

            bool isPrimaryValueNotChange = Enumerable.SequenceEqual(oldPrimaryValues, newPrimaryValues);
            if (isPrimaryValueNotChange)
            {
                Update(newEntity);
                return;
            }

            bool isExistedInDB = ExistByIds(newPrimaryValues);
            if (isExistedInDB)
            {
                throw new ClinicEntityIllegalStateException("Đối tượng này đã tồn tại, không thể cập nhật!");
            }

            Delete(oldPrimaryValues);
            Add(newEntity);
        }

        public void Delete(params object[] keys)
        {
            repository.Delete(keys);
        }

        public List<E> FindByFuzzy(string searchText)
        {
            return repository.FindByFuzzy(searchText);
        }

    }
}
