using System.Linq;

namespace Cis.Data.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity, bool commit);
        void Update(T entity, bool commit);
        void Delete(int id, bool commit);
        void Delete(T entity, bool commit);
        void Commit();
    }
}
