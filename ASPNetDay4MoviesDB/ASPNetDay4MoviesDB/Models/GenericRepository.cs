using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace ASPNetDay4MoviesDB.Models
{
    public class GenericRepository : ASPNetDay4MoviesDB.Models.IGenericRepository
    {
        private DataContext _dataContext = new DataContext();

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
            catch(DbEntityValidationException dbVal)
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