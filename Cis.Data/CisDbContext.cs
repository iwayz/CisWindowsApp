using Cis.Model;
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
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SalesArea> SalesAreas { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderItem> SalesOrderItems { get; set; }
        public DbSet<TermOfPayment> TermOfPayments { get; set; }
        public DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }
        public DbSet<UsageType> UsageTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Properties configurations
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Entities configurations
            // Batch to Product
            modelBuilder.Entity<Batch>()
                .HasRequired(b => b.Product)
                .WithMany(p => p.Batches)
                .HasForeignKey(b => b.ProductId)
                .WillCascadeOnDelete(false);

            // Customer to Sales Area and Outlet Type
            modelBuilder.Entity<Customer>()
                .HasRequired(c => c.SalesArea)
                .WithMany(s => s.Customers)
                .HasForeignKey(c => c.SalesAreaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasRequired(c => c.OutletType)
                .WithMany(o => o.Customers)
                .HasForeignKey(c => c.OutletTypeId)
                .WillCascadeOnDelete(false);

            // Permission Role to Role and Permission
            modelBuilder.Entity<PermissionRole>()
                .HasRequired(p => p.Role)
                .WithMany(r => r.PermissionRoles)
                .HasForeignKey(p => p.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PermissionRole>()
                .HasRequired(pr => pr.Permission)
                .WithMany(p => p.PermissionRoles)
                .HasForeignKey(pr => pr.PermisionId)
                .WillCascadeOnDelete(false);

            // Product to Unit, MedicineCat, Usage Type and Principal
            modelBuilder.Entity<Product>()
                .HasRequired(p => p.Unit)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UnitId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.MedicineCat)
                .WithMany(m => m.Products)
                .HasForeignKey(p => p.MedicineCatId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasRequired(p => p.UsageType)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UsageTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasRequired(pd => pd.Principal)
                .WithMany(pc => pc.Products)
                .HasForeignKey(pd => pd.PrincipalId)
                .WillCascadeOnDelete(false);

            // User Role to Role and User
            modelBuilder.Entity<UserRole>()
                .HasRequired(u => u.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(u => u.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserRole>()
                .HasRequired(ur => ur.User)
                .WithMany(us => us.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .WillCascadeOnDelete(false);

            // Sales Order to Customer, Sales Area, User, Term of Payment, and Salesman
            modelBuilder.Entity<SalesOrder>()
                .HasRequired(so => so.Customer)
                .WithMany(c => c.SalesOrders)
                .HasForeignKey(so => so.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrder>()
                .HasRequired(so => so.SalesArea)
                .WithMany(sa => sa.SalesOrders)
                .HasForeignKey(so => so.SalesAreaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrder>()
                .HasRequired(so => so.User)
                .WithMany(u => u.SalesOrders)
                .HasForeignKey(so => so.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrder>()
                .HasRequired(so => so.TermOfPayment)
                .WithMany(t => t.SalesOrders)
                .HasForeignKey(so => so.TermOfPaymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrder>()
                .HasRequired(so => so.Salesman)
                .WithMany(s => s.SalesOrders)
                .HasForeignKey(so => so.SalesmanId)
                .WillCascadeOnDelete(false);

            // Sales Order Item to Sales Order
            modelBuilder.Entity<SalesOrderItem>()
                .HasRequired(oi => oi.SalesOrder)
                .WithMany(so => so.SalesOrderItems)
                .HasForeignKey(oi => oi.SalesOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderItem>()
                .HasRequired(oi => oi.Product)
                .WithMany(p => p.SalesOrderItems)
                .HasForeignKey(oi => oi.ProductId)
                .WillCascadeOnDelete(false);

            // Activate this when the Batch is really in-use
            //modelmodelBuilder.Entity<SalesOrderItem>()
            //    .HasRequired(oi => oi.Batch)
            //    .WithMany(b => b.SalesOrderItems)
            //    .HasForeignKey(oi => oi.BatchId)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderItem>()
                .HasRequired(oi => oi.UnitOfMeasurement)
                .WithMany(u => u.SalesOrderItems)
                .HasForeignKey(oi => oi.UomId)
                .WillCascadeOnDelete(false);
        }
    }
}
