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
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MedicineCat> MedicineCategories { get; set; }
        public DbSet<OutletType> OutletTypes { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionRole> PermissionRoles { get; set; }
        public DbSet<Principal> Principals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Representative> Representatives { get; set; }
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

        // Stock Management
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }
        public DbSet<PurchaseReturnItem> PurchaseReturnItems { get; set; }
        public DbSet<SalesReturn> SalesReturns { get; set; }
        public DbSet<SalesReturnItem> SalesReturnItems { get; set; }
        public DbSet<StockCard> StockCards { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<StockTransfer> StockTransfers { get; set; }
        public DbSet<StockTransferItem> StockTransferItems { get; set; }
        public DbSet<StockOpname> StockOpnames { get; set; }
        public DbSet<StockOpnameItem> StockOpnameItems { get; set; }
        public DbSet<StockAdjustment> StockAdjustments { get; set; }
        public DbSet<StockAdjustmentItem> StockAdjustmentItems { get; set; }

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
                .WithMany(o => o.SalesOrderItems)
                .HasForeignKey(oi => oi.UomId)
                .WillCascadeOnDelete(false);

            // Sales Area to Representative
            modelBuilder.Entity<SalesArea>()
                .HasRequired(sa => sa.Representative)
                .WithMany(r => r.SalesAreas)
                .HasForeignKey(sa => sa.RepresentativeId)
                .WillCascadeOnDelete(false);

            // SalesReturn to SalesOrder, Customer, User
            modelBuilder.Entity<SalesReturn>()
                .HasRequired(sr => sr.SalesOrder)
                .WithMany(so => so.SalesReturns)
                .HasForeignKey(sr => sr.SalesOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesReturn>()
                .HasRequired(sr => sr.Customer)
                .WithMany()
                .HasForeignKey(sr => sr.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesReturn>()
                .HasRequired(sr => sr.User)
                .WithMany()
                .HasForeignKey(sr => sr.UserId)
                .WillCascadeOnDelete(false);

            // SalesReturnItem to SalesReturn, Product, UnitOfMeasurement
            modelBuilder.Entity<SalesReturnItem>()
                .HasRequired(i => i.SalesReturn)
                .WithMany(sr => sr.SalesReturnItems)
                .HasForeignKey(i => i.SalesReturnId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesReturnItem>()
                .HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesReturnItem>()
                .HasRequired(i => i.UnitOfMeasurement)
                .WithMany()
                .HasForeignKey(i => i.UomId)
                .WillCascadeOnDelete(false);

            // PurchaseOrder to Principal (supplier), User
            modelBuilder.Entity<PurchaseOrder>()
                .HasRequired(po => po.Supplier)
                .WithMany(s => s.PurchaseOrders)
                .HasForeignKey(po => po.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrder>()
                .HasRequired(po => po.User)
                .WithMany()
                .HasForeignKey(po => po.UserId)
                .WillCascadeOnDelete(false);

            // PurchaseOrderItem to PurchaseOrder, Product, UnitOfMeasurement
            modelBuilder.Entity<PurchaseOrderItem>()
                .HasRequired(i => i.PurchaseOrder)
                .WithMany(po => po.PurchaseOrderItems)
                .HasForeignKey(i => i.PurchaseOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrderItem>()
                .HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrderItem>()
                .HasRequired(i => i.UnitOfMeasurement)
                .WithMany()
                .HasForeignKey(i => i.UomId)
                .WillCascadeOnDelete(false);

            // PurchaseReturn to PurchaseOrder, Principal (supplier), User
            modelBuilder.Entity<PurchaseReturn>()
                .HasRequired(pr => pr.PurchaseOrder)
                .WithMany(po => po.PurchaseReturns)
                .HasForeignKey(pr => pr.PurchaseOrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseReturn>()
                .HasRequired(pr => pr.Supplier)
                .WithMany(s => s.PurchaseReturns)
                .HasForeignKey(pr => pr.SupplierId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseReturn>()
                .HasRequired(pr => pr.User)
                .WithMany()
                .HasForeignKey(pr => pr.UserId)
                .WillCascadeOnDelete(false);

            // PurchaseReturnItem to PurchaseReturn, Product, UnitOfMeasurement
            modelBuilder.Entity<PurchaseReturnItem>()
                .HasRequired(i => i.PurchaseReturn)
                .WithMany(pr => pr.PurchaseReturnItems)
                .HasForeignKey(i => i.PurchaseReturnId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseReturnItem>()
                .HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseReturnItem>()
                .HasRequired(i => i.UnitOfMeasurement)
                .WithMany()
                .HasForeignKey(i => i.UomId)
                .WillCascadeOnDelete(false);

            // StockCard to Product
            modelBuilder.Entity<StockCard>()
                .HasRequired(sc => sc.Product)
                .WithMany()
                .HasForeignKey(sc => sc.ProductId)
                .WillCascadeOnDelete(false);

            // StockMovement to Product
            modelBuilder.Entity<StockMovement>()
                .HasRequired(sm => sm.Product)
                .WithMany()
                .HasForeignKey(sm => sm.ProductId)
                .WillCascadeOnDelete(false);

            // StockTransfer to User
            modelBuilder.Entity<StockTransfer>()
                .HasRequired(st => st.User)
                .WithMany()
                .HasForeignKey(st => st.UserId)
                .WillCascadeOnDelete(false);

            // StockTransferItem to StockTransfer, Product, UnitOfMeasurement
            modelBuilder.Entity<StockTransferItem>()
                .HasRequired(i => i.StockTransfer)
                .WithMany(st => st.StockTransferItems)
                .HasForeignKey(i => i.StockTransferId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockTransferItem>()
                .HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockTransferItem>()
                .HasRequired(i => i.UnitOfMeasurement)
                .WithMany()
                .HasForeignKey(i => i.UomId)
                .WillCascadeOnDelete(false);

            // StockOpname to User
            modelBuilder.Entity<StockOpname>()
                .HasRequired(so => so.User)
                .WithMany()
                .HasForeignKey(so => so.UserId)
                .WillCascadeOnDelete(false);

            // StockOpnameItem to StockOpname, Product, UnitOfMeasurement
            modelBuilder.Entity<StockOpnameItem>()
                .HasRequired(i => i.StockOpname)
                .WithMany(so => so.StockOpnameItems)
                .HasForeignKey(i => i.StockOpnameId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockOpnameItem>()
                .HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockOpnameItem>()
                .HasRequired(i => i.UnitOfMeasurement)
                .WithMany()
                .HasForeignKey(i => i.UomId)
                .WillCascadeOnDelete(false);

            // StockAdjustment to User, StockOpname
            modelBuilder.Entity<StockAdjustment>()
                .HasRequired(sa => sa.User)
                .WithMany()
                .HasForeignKey(sa => sa.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockAdjustment>()
                .HasOptional(sa => sa.StockOpname)
                .WithMany()
                .HasForeignKey(sa => sa.StockOpnameId)
                .WillCascadeOnDelete(false);

            // StockAdjustmentItem to StockAdjustment, Product, UnitOfMeasurement
            modelBuilder.Entity<StockAdjustmentItem>()
                .HasRequired(i => i.StockAdjustment)
                .WithMany(sa => sa.StockAdjustmentItems)
                .HasForeignKey(i => i.StockAdjustmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockAdjustmentItem>()
                .HasRequired(i => i.Product)
                .WithMany()
                .HasForeignKey(i => i.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StockAdjustmentItem>()
                .HasRequired(i => i.UnitOfMeasurement)
                .WithMany()
                .HasForeignKey(i => i.UomId)
                .WillCascadeOnDelete(false);
        }
    }
}
