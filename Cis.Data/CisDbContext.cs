using Cis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MySQL.Data.EntityFrameworkCore;
using System.Reflection;

namespace Cis.Data
{
    public partial class CisDbContext: DbContext
    {
        public CisDbContext(): base()
        {
            
        }

        public CisDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Customer> Consumers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OutletType> OutletTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<UnitOfMeasurement> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("MySQLConnectionString"); // Todo: get a way to read from app.config
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Applying the configuration for all entities set.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Seeding when required.

        }
    }
}
