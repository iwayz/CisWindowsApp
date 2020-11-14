using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.DataContract
{
    public interface IUnitOfWork<T> : IDisposable where T : class, IEntity
    {
        IRepository<T> Repository { get; }

        void Commit();
    }
}
