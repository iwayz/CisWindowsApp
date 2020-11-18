using Cis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using MySql.Data.EntityFrameworkCore;

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

        public DbSet<Batch> Batches{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MedicineCat> MedicineCategories { get; set; }
        public DbSet<OutletType> OutletTypes { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesArea> SalesAreas { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<UsageType> UsageTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseMySQL(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                optionsBuilder.UseMySQL("Server = localhost; Database = CIS_POS; Uid = root; Pwd = admin;"); 
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Applying the configuration for all entities set.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
    }
}
