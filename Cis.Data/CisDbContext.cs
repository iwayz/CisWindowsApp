﻿using Cis.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace Cis.Data
{
    public partial class CisDbContext : DbContext
    {
        public CisDbContext() : base("name=DefaultConnection")
        {

        }
       
        public DbSet<Batch> Batches { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelmodelBuilder)
        {

            // Properties configurations
            modelmodelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelmodelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Entities configurations
            // Batch to Product
            modelmodelBuilder.Entity<Batch>()
                .HasRequired(b => b.Product)
                .WithMany(p => p.Batches)
                .HasForeignKey(b => b.ProductId)
                .WillCascadeOnDelete(false);

            // Customer to Sales Area and Outlet Type
            modelmodelBuilder.Entity<Customer>()
                .HasRequired(c => c.SalesArea)
                .WithMany(s => s.Customers)
                .HasForeignKey(c => c.SalesAreaId)
                .WillCascadeOnDelete(false);

            modelmodelBuilder.Entity<Customer>()
                .HasRequired(c => c.OutletType)
                .WithMany(o => o.Customers)
                .HasForeignKey(c => c.OutletTypeId)
                .WillCascadeOnDelete(false);

            // Permission Role to Role
            modelmodelBuilder.Entity<PermissionRole>()
                .HasRequired(p => p.Role)
                .WithMany(r => r.PermissionRoles)
                .HasForeignKey(p => p.RoleId)
                .WillCascadeOnDelete(false);

            // Product to Unit, MedicineCat, Usage Type and Principal
            modelmodelBuilder.Entity<Product>()
                .HasRequired(p => p.Unit)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UnitId)
                .WillCascadeOnDelete(false);

            modelmodelBuilder.Entity<Product>()
                .HasRequired(p => p.MedicineCat)
                .WithMany(m => m.Products)
                .HasForeignKey(p => p.MedicineCatId)
                .WillCascadeOnDelete(false);

            modelmodelBuilder.Entity<Product>()
                .HasRequired(p => p.UsageType)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UsageTypeId)
                .WillCascadeOnDelete(false);

            modelmodelBuilder.Entity<Product>()
                .HasRequired(pd => pd.Principal)
                .WithMany(pc => pc.Products)
                .HasForeignKey(pd => pd.PrincipalId)
                .WillCascadeOnDelete(false);

            // User Role to Role and User Role
            modelmodelBuilder.Entity<UserRole>()
                .HasRequired(u => u.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(u => u.RoleId)
                .WillCascadeOnDelete(false);

            modelmodelBuilder.Entity<UserRole>()
                .HasRequired(ur => ur.User)
                .WithMany(us => us.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
