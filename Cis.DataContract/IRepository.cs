using System.Linq;
using System.Collections.Generic;
using System;

namespace Cis.DataContract
{
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();

        T GetById(Guid id);

        void Add(T entity);

        void Add(IEnumerable<T> entities);

        void Update(T entity);

        void Update(IEnumerable<T> entities);

        void Delete(T entity);

        void Delete(IEnumerable<T> entities);
    }
}
