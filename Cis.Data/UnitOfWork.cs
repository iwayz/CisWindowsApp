using Cis.DataContract;

namespace Cis.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class, IEntity
    {
        private readonly CisDbContext dbContext;
        public UnitOfWork(CisDbContext context)
        {
            dbContext = context;
            Repository = new CisRepository<T>(context);
        }

        public IRepository<T> Repository { get; }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
