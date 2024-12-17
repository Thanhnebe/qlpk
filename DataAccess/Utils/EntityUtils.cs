
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace DataAccess.Utils
{
    public sealed class EntityUtils
    {

        public static object[] GetValuesFromEntityByProperties<E>(E entity, params string[] properties)
        {
            return properties.ToList()
                             .Select(p => entity.GetType().GetProperty(p).GetValue(entity))
                             .ToArray();
        }

        public static object[] GetPrimaryKeyValues<E>(E entity)
        {
            return GetPrimaryKeyNames(typeof(E)).ToList()
                                                .Select(primaryKey => entity.GetType()
                                                                            .GetProperty(primaryKey)
                                                                            .GetValue(entity)).ToArray();
        }

        public static string[] GetPrimaryKeyNames(Type entityType)
        {
            using (ClinicEntities dbContext = new ClinicEntities())
            {
                var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;
                var metadata = objectContext.MetadataWorkspace;
                var entitySets = metadata.GetEntityContainer(objectContext.DefaultContainerName, DataSpace.CSpace).EntitySets;

                return entitySets.First(e => e.ElementType.Name == entityType.Name).ElementType.KeyProperties.Select(p => p.Name).ToArray();

/*                EntitySet entitySet = entitySets.First(e => e.ElementType.Name == entityType.Name);

                List<string> allProperties = entitySet.ElementType
                                                      .DeclaredProperties
                                                      .Select(p => p.Name)
                                                      .ToList();

                return entitySet.ElementType
                                .KeyProperties
                                .OrderBy(k => allProperties.IndexOf(k.Name))
                                .Select(k => k.Name)
                                .ToArray();*/
            }            
        }

    }
}
