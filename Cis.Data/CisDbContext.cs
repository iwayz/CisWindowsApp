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
        public DbSet<Unit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("MySQLConnectionString"); // Todo: get a way to read from app.config
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Master entities
            modelBuilder.Entity<Location>()
                .HasOne(f => f.Parent)
                .WithMany(f => f.Children)
                .HasForeignKey(f => f.ParentId);

            modelBuilder.Entity<Batch>()
                .HasOne(b => b.Product)
                .WithMany(p => p.Batches)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Unit)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UnitId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.MedicineCat)
                .WithMany(m => m.Products)
                .HasForeignKey(p => p.MedicineCatId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.UsageType)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UsageTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Principal)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.PrincipalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.SalesArea)
                .WithMany(s => s.Customers)
                .HasForeignKey(c => c.SalesAreaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Applying the configuration for all entities set.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Seeding when required.

        }
    }
}
