using Cis.DataContract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace Cis.Data
{
    public class CisRepository<T> : IRepository<T> where T : class, IEntity
    {
        DbSet<T> Entity { get; set; }
        CisDbContext _dbCisDbContext;

        public CisRepository(CisDbContext cisDbContext)
        {
            Entity = cisDbContext.Set<T>();
            _dbCisDbContext = cisDbContext;
        }
        public void Add(T entity) => Entity.Add(entity);

        public void Add(IEnumerable<T> entities) => Entity.AddRange(entities);

        public void Delete(T entity) => Entity.Remove(entity);

        public void Delete(IEnumerable<T> entities) => Entity.RemoveRange(entities);

        public IQueryable<T> GetAll() => Entity;

        public T GetById(string id)
        {
            return GetAll().FirstOrDefault(e => e.Id == id);
        }

        public void Update(T entity)
        {
            _dbCisDbContext.Entry(entity).State = EntityState.Modified; 
        }

    }
}
