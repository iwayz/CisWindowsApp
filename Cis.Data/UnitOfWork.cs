using Cis.DataContract;
using NLog;
using System;
using System.Data.Entity.Infrastructure;

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

        public (bool, string) Commit()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            try
            {
                dbContext.SaveChanges();
                return(true, string.Empty);
            }
            catch (DbUpdateException dbEx)
            {
                logger.Error(dbEx.InnerException.InnerException.Message, "Expected");
                return (false, "Expected");
            }
            catch (Exception ex)
            {
                logger.Error(ex.InnerException.InnerException.Message, "Unexpected");
                return (false, "Unexpected");
            }
            finally
            {
                LogManager.Shutdown();
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
