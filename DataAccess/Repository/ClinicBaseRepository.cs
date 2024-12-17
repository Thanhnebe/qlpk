using DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Design.PluralizationServices;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository
{
    public abstract class User<E> : IClinicRepository<E> where E : class
    {
        private PluralizationService pluralizationService;

        public User() {
            pluralizationService = PluralizationService.CreateService(CultureInfo.GetCultureInfo("en-us"));
        }
        
        protected virtual Expression<Func<E, bool>> GetSearchAnythingExpression(string searchText)
        {
            throw new NotImplementedException();
        }

        protected DbSet<E> GetDbSet(ClinicEntities dbContext)
        {
            return (DbSet<E>)dbContext.GetType()
                                      .GetProperty(pluralizationService.Pluralize(typeof(E).Name))
                                      .GetValue(dbContext);
        }

        protected void RunInContext(Action<ClinicEntities> consumer)
        {
            using (ClinicEntities entities = new ClinicEntities())
            {
                consumer.Invoke(entities);
            }
        }

        protected R CallInContext<R>(Func<ClinicEntities, R> func) {
            using (ClinicEntities entities = new ClinicEntities())
            {
                return func.Invoke(entities);
            }
        }

        public virtual List<E> FindAll()
        {
            return CallInContext(dbContext =>
            {
                return GetDbSet(dbContext).ToList();
            });
        }

        public List<E> FindAllWithInclude(params string[] includes)
        {
            if (includes == null || includes.Length == 0)
            {
                return FindAll();
            }

            return CallInContext(dbContext =>
            {
                DbQuery<E> query = GetDbSet(dbContext).Include(includes[0]);
                for (int i = 1; i < includes.Length; i++)
                {
                    query = GetDbSet(dbContext).Include(includes[i]);
                }
                return query.ToList();
            });
        }

        public List<E> FindAllOrderByDES<R>(Expression<Func<E, R>> orderByExpression)
        {
            return CallInContext(dbContext =>
            {
                return GetDbSet(dbContext).OrderByDescending(orderByExpression)
                                          .Select(e => e)
                                          .ToList();
            });
        }

        public E FindByIds(params object[] ids)
        {
            return CallInContext(dbContext =>
            {
                return GetDbSet(dbContext).Find(ids);
            });
        }

        public void Add(E entity)
        {
            RunInContext(dbContext => {
                GetDbSet(dbContext).Add(entity);
                dbContext.SaveChanges();
            });
        }

        public void Update(E entity)
        {
            RunInContext(dbContext =>
            {
                E objInDb = GetDbSet(dbContext).Find(EntityUtils.GetPrimaryKeyValues(entity));
                dbContext.Entry(objInDb).CurrentValues.SetValues(entity);
                dbContext.SaveChanges();
            });
        }

        public void Delete(params object[] ids)
        {
            RunInContext(dbContext =>
            {
                DbSet<E> dbSet = GetDbSet(dbContext);
                E objInDb = dbSet.Find(ids);
                dbSet.Remove(objInDb);
                dbContext.SaveChanges();
            });
        }

        public bool ExistByIds(params object[] ids)
        {
            return CallInContext(dbContext =>
            {
                DbSet<E> dbSet = GetDbSet(dbContext);
                return dbSet.Find(ids) != null;
            });
        }

        public virtual List<E> FindByFuzzy(string searchText)
        {
            return CallInContext(dbContext =>
            {
                return GetDbSet(dbContext)
                               .Where(GetSearchAnythingExpression(searchText.ToLower()))
                               .Select(p => p)
                               .ToList();
            });
        }

    }
}
