using Cis.Data.Interfaces;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace Cis.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext DbContext { get; set; }

        protected DbSet<T> DbSet { get; set; }

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext ?? throw new ArgumentNullException("Null DbContext");
            DbSet = DbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity, bool commit = true)
        {
            var dbContextEntry = DbContext.Entry(entity);
            if (dbContextEntry.State != EntityState.Detached)
            {
                dbContextEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
            if (commit) Commit();
        }

        public void Update(T entity, bool commit = true)
        {
            var dbContextEntry = DbContext.Entry(entity);
            if (dbContextEntry.State != EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbContextEntry.State = EntityState.Modified;
            if (commit) Commit();
        }

        public void Delete(int id, bool commit = true)
        {
            var entityToDel = GetById(id);
            if (entityToDel == null) return;
            Delete(entityToDel, commit);
        }

        public void Delete(T entity, bool commit = true)
        {
            var dbContextEntry = DbContext.Entry(entity);
            if (dbContextEntry.State != EntityState.Deleted)
            {
                dbContextEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
            if (commit) Commit();
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
