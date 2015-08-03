using ProductApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure.Persistence.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private ProductsDbContext _dataContext = new ProductsDbContext();

        public IQueryable<T> Query<T>() where T : class
        {
            return _dataContext.Set<T>().AsQueryable();
        }

        public IQueryable Query(string entityTypeName)
        {
            var entityType = Type.GetType(entityTypeName);
            return _dataContext.Set(entityType).AsQueryable();
        }

        public T Find<T>(params object[] keyValues) where T : class
        {
            return _dataContext.Set<T>().Find(keyValues);
        }

        public void Add<T>(T entityToCreate) where T : class
        {
            _dataContext.Set<T>().Add(entityToCreate);
        }

        public void Delete<T>(params object[] keyValues) where T : class
        {
            var entity = this.Find<T>(keyValues);
            _dataContext.Set<T>().Remove(entity);
        }

        public void SaveChanges()
        {
            try
            {
                _dataContext.SaveChanges();
            }
            catch (DbEntityValidationException dbVal)
            {
                var firstError = dbVal.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                throw new ValidationException(firstError);
            }
        }

        public IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters)
        {
            return this._dataContext.Database.SqlQuery<T>(sql, parameters);
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
