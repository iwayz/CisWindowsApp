namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddStockManagement : DbMigration
    {
        public override void Up()
        {
            // Add new columns to Principal (used as Supplier)
            AddColumn("dbo.Principal", "ContactPerson", c => c.String(maxLength: 100));
            AddColumn("dbo.Principal", "Npwp", c => c.String(maxLength: 30));

            // PurchaseOrder
            CreateTable(
                "dbo.PurchaseOrder",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    PONumber = c.String(nullable: false, maxLength: 20),
                    SupplierId = c.String(nullable: false, maxLength: 36),
                    SupplierName = c.String(nullable: false, maxLength: 100),
                    SupplierAddress = c.String(),
                    SupplierPhone = c.String(maxLength: 20),
                    OrderDate = c.DateTime(nullable: false),
                    ExpectedDate = c.DateTime(nullable: false),
                    ReceivedDate = c.DateTime(),
                    SubTotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    TaxBaseAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    ValueAddedTaxAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    GrandTotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    Notes = c.String(),
                    PostingStatus = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 36),
                    Username = c.String(nullable: false, maxLength: 50),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Principal", t => t.SupplierId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.PONumber, unique: true)
                .Index(t => t.SupplierId)
                .Index(t => t.UserId);

            // PurchaseOrderItem
            CreateTable(
                "dbo.PurchaseOrderItem",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    PurchaseOrderId = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    ExpiredDate = c.DateTime(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UomId = c.String(nullable: false, maxLength: 36),
                    UomCode = c.String(nullable: false, maxLength: 20),
                    Price = c.Decimal(nullable: false, precision: 15, scale: 5),
                    DiscountPercentage = c.Single(nullable: false),
                    TotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseOrder", t => t.PurchaseOrderId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UomId)
                .Index(t => t.PurchaseOrderId)
                .Index(t => t.ProductId)
                .Index(t => t.UomId);

            // PurchaseReturn
            CreateTable(
                "dbo.PurchaseReturn",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    ReturnNumber = c.String(nullable: false, maxLength: 20),
                    PurchaseOrderId = c.String(nullable: false, maxLength: 36),
                    PONumber = c.String(nullable: false, maxLength: 20),
                    SupplierId = c.String(nullable: false, maxLength: 36),
                    SupplierName = c.String(nullable: false, maxLength: 100),
                    ReturnDate = c.DateTime(nullable: false),
                    Reason = c.String(),
                    TotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    PostingStatus = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 36),
                    Username = c.String(nullable: false, maxLength: 50),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseOrder", t => t.PurchaseOrderId)
                .ForeignKey("dbo.Principal", t => t.SupplierId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.ReturnNumber, unique: true)
                .Index(t => t.PurchaseOrderId)
                .Index(t => t.SupplierId)
                .Index(t => t.UserId);

            // PurchaseReturnItem
            CreateTable(
                "dbo.PurchaseReturnItem",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    PurchaseReturnId = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    ExpiredDate = c.DateTime(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UomId = c.String(nullable: false, maxLength: 36),
                    UomCode = c.String(nullable: false, maxLength: 20),
                    Price = c.Decimal(nullable: false, precision: 15, scale: 5),
                    TotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PurchaseReturn", t => t.PurchaseReturnId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UomId)
                .Index(t => t.PurchaseReturnId)
                .Index(t => t.ProductId)
                .Index(t => t.UomId);

            // SalesReturn
            CreateTable(
                "dbo.SalesReturn",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    ReturnNumber = c.String(nullable: false, maxLength: 20),
                    SalesOrderId = c.String(nullable: false, maxLength: 36),
                    SalesNo = c.String(nullable: false, maxLength: 20),
                    CustomerId = c.String(nullable: false, maxLength: 36),
                    CustomerName = c.String(nullable: false, maxLength: 100),
                    ReturnDate = c.DateTime(nullable: false),
                    Reason = c.String(),
                    TotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    PostingStatus = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 36),
                    Username = c.String(nullable: false, maxLength: 50),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesOrder", t => t.SalesOrderId)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.ReturnNumber, unique: true)
                .Index(t => t.SalesOrderId)
                .Index(t => t.CustomerId)
                .Index(t => t.UserId);

            // SalesReturnItem
            CreateTable(
                "dbo.SalesReturnItem",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    SalesReturnId = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    ExpiredDate = c.DateTime(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UomId = c.String(nullable: false, maxLength: 36),
                    UomCode = c.String(nullable: false, maxLength: 20),
                    Price = c.Decimal(nullable: false, precision: 15, scale: 5),
                    TotalAmount = c.Decimal(nullable: false, precision: 15, scale: 5),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesReturn", t => t.SalesReturnId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UomId)
                .Index(t => t.SalesReturnId)
                .Index(t => t.ProductId)
                .Index(t => t.UomId);

            // StockCard
            CreateTable(
                "dbo.StockCard",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    QtyOnHand = c.Decimal(nullable: false, precision: 15, scale: 5),
                    QtyReserved = c.Decimal(nullable: false, precision: 15, scale: 5),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .Index(t => new { t.ProductId, t.BatchId }, unique: true, name: "IX_StockCard_ProductBatch");

            // StockMovement
            CreateTable(
                "dbo.StockMovement",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    MovementDate = c.DateTime(nullable: false),
                    MovementType = c.Int(nullable: false),
                    Direction = c.Int(nullable: false),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    Qty = c.Decimal(nullable: false, precision: 15, scale: 5),
                    ReferenceType = c.String(maxLength: 50),
                    ReferenceId = c.String(maxLength: 36),
                    Remarks = c.String(),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .Index(t => t.ProductId)
                .Index(t => t.MovementDate);

            // StockTransfer
            CreateTable(
                "dbo.StockTransfer",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    TransferNumber = c.String(nullable: false, maxLength: 20),
                    TransferType = c.Int(nullable: false),
                    BranchName = c.String(nullable: false, maxLength: 100),
                    TransferDate = c.DateTime(nullable: false),
                    Notes = c.String(),
                    PostingStatus = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 36),
                    Username = c.String(nullable: false, maxLength: 50),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.TransferNumber, unique: true)
                .Index(t => t.UserId);

            // StockTransferItem
            CreateTable(
                "dbo.StockTransferItem",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    StockTransferId = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    Quantity = c.Decimal(nullable: false, precision: 15, scale: 5),
                    UomId = c.String(nullable: false, maxLength: 36),
                    UomCode = c.String(nullable: false, maxLength: 20),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockTransfer", t => t.StockTransferId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UomId)
                .Index(t => t.StockTransferId)
                .Index(t => t.ProductId)
                .Index(t => t.UomId);

            // StockOpname
            CreateTable(
                "dbo.StockOpname",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    OpnameNumber = c.String(nullable: false, maxLength: 20),
                    OpnameType = c.Int(nullable: false),
                    OpnameDate = c.DateTime(nullable: false),
                    Notes = c.String(),
                    PostingStatus = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 36),
                    Username = c.String(nullable: false, maxLength: 50),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.OpnameNumber, unique: true)
                .Index(t => t.UserId);

            // StockOpnameItem
            CreateTable(
                "dbo.StockOpnameItem",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    StockOpnameId = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    UomId = c.String(nullable: false, maxLength: 36),
                    UomCode = c.String(nullable: false, maxLength: 20),
                    QtySystem = c.Decimal(nullable: false, precision: 15, scale: 5),
                    QtyPhysical = c.Decimal(nullable: false, precision: 15, scale: 5),
                    Difference = c.Decimal(nullable: false, precision: 15, scale: 5),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockOpname", t => t.StockOpnameId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UomId)
                .Index(t => t.StockOpnameId)
                .Index(t => t.ProductId)
                .Index(t => t.UomId);

            // StockAdjustment
            CreateTable(
                "dbo.StockAdjustment",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    AdjustmentNumber = c.String(nullable: false, maxLength: 20),
                    AdjustmentDate = c.DateTime(nullable: false),
                    Reason = c.Int(nullable: false),
                    Notes = c.String(),
                    PostingStatus = c.Int(nullable: false),
                    UserId = c.String(nullable: false, maxLength: 36),
                    Username = c.String(nullable: false, maxLength: 50),
                    StockOpnameId = c.String(maxLength: 36),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId)
                .ForeignKey("dbo.StockOpname", t => t.StockOpnameId)
                .Index(t => t.AdjustmentNumber, unique: true)
                .Index(t => t.UserId)
                .Index(t => t.StockOpnameId);

            // StockAdjustmentItem
            CreateTable(
                "dbo.StockAdjustmentItem",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    StockAdjustmentId = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    ProductCode = c.String(nullable: false, maxLength: 50),
                    ProductName = c.String(nullable: false, maxLength: 100),
                    BatchId = c.String(maxLength: 36),
                    BatchCode = c.String(maxLength: 50),
                    UomId = c.String(nullable: false, maxLength: 36),
                    UomCode = c.String(nullable: false, maxLength: 20),
                    QtyBefore = c.Decimal(nullable: false, precision: 15, scale: 5),
                    QtyAdjustment = c.Decimal(nullable: false, precision: 15, scale: 5),
                    QtyAfter = c.Decimal(nullable: false, precision: 15, scale: 5),
                    Direction = c.Int(nullable: false),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockAdjustment", t => t.StockAdjustmentId)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UomId)
                .Index(t => t.StockAdjustmentId)
                .Index(t => t.ProductId)
                .Index(t => t.UomId);

            // Alter existing tables
            AddColumn("dbo.SalesOrder", "PostingStatus", c => c.Int(nullable: false, defaultValue: 0));
            AddColumn("dbo.Product", "IsBatchTracked", c => c.Boolean(nullable: false, defaultValue: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Product", "IsBatchTracked");
            DropColumn("dbo.SalesOrder", "PostingStatus");

            DropIndex("dbo.StockAdjustmentItem", new[] { "UomId" });
            DropIndex("dbo.StockAdjustmentItem", new[] { "ProductId" });
            DropIndex("dbo.StockAdjustmentItem", new[] { "StockAdjustmentId" });
            DropIndex("dbo.StockAdjustment", new[] { "StockOpnameId" });
            DropIndex("dbo.StockAdjustment", new[] { "UserId" });
            DropIndex("dbo.StockAdjustment", new[] { "AdjustmentNumber" });
            DropIndex("dbo.StockOpnameItem", new[] { "UomId" });
            DropIndex("dbo.StockOpnameItem", new[] { "ProductId" });
            DropIndex("dbo.StockOpnameItem", new[] { "StockOpnameId" });
            DropIndex("dbo.StockOpname", new[] { "UserId" });
            DropIndex("dbo.StockOpname", new[] { "OpnameNumber" });
            DropIndex("dbo.StockTransferItem", new[] { "UomId" });
            DropIndex("dbo.StockTransferItem", new[] { "ProductId" });
            DropIndex("dbo.StockTransferItem", new[] { "StockTransferId" });
            DropIndex("dbo.StockTransfer", new[] { "UserId" });
            DropIndex("dbo.StockTransfer", new[] { "TransferNumber" });
            DropIndex("dbo.StockMovement", new[] { "MovementDate" });
            DropIndex("dbo.StockMovement", new[] { "ProductId" });
            DropIndex("dbo.StockCard", "IX_StockCard_ProductBatch");
            DropIndex("dbo.SalesReturnItem", new[] { "UomId" });
            DropIndex("dbo.SalesReturnItem", new[] { "ProductId" });
            DropIndex("dbo.SalesReturnItem", new[] { "SalesReturnId" });
            DropIndex("dbo.SalesReturn", new[] { "UserId" });
            DropIndex("dbo.SalesReturn", new[] { "CustomerId" });
            DropIndex("dbo.SalesReturn", new[] { "SalesOrderId" });
            DropIndex("dbo.SalesReturn", new[] { "ReturnNumber" });
            DropIndex("dbo.PurchaseReturnItem", new[] { "UomId" });
            DropIndex("dbo.PurchaseReturnItem", new[] { "ProductId" });
            DropIndex("dbo.PurchaseReturnItem", new[] { "PurchaseReturnId" });
            DropIndex("dbo.PurchaseReturn", new[] { "UserId" });
            DropIndex("dbo.PurchaseReturn", new[] { "SupplierId" });
            DropIndex("dbo.PurchaseReturn", new[] { "PurchaseOrderId" });
            DropIndex("dbo.PurchaseReturn", new[] { "ReturnNumber" });
            DropIndex("dbo.PurchaseOrderItem", new[] { "UomId" });
            DropIndex("dbo.PurchaseOrderItem", new[] { "ProductId" });
            DropIndex("dbo.PurchaseOrderItem", new[] { "PurchaseOrderId" });
            DropIndex("dbo.PurchaseOrder", new[] { "UserId" });
            DropIndex("dbo.PurchaseOrder", new[] { "SupplierId" });
            DropIndex("dbo.PurchaseOrder", new[] { "PONumber" });

            DropTable("dbo.StockAdjustmentItem");
            DropTable("dbo.StockAdjustment");
            DropTable("dbo.StockOpnameItem");
            DropTable("dbo.StockOpname");
            DropTable("dbo.StockTransferItem");
            DropTable("dbo.StockTransfer");
            DropTable("dbo.StockMovement");
            DropTable("dbo.StockCard");
            DropTable("dbo.SalesReturnItem");
            DropTable("dbo.SalesReturn");
            DropTable("dbo.PurchaseReturnItem");
            DropTable("dbo.PurchaseReturn");
            DropTable("dbo.PurchaseOrderItem");
            DropTable("dbo.PurchaseOrder");

            DropColumn("dbo.Principal", "Npwp");
            DropColumn("dbo.Principal", "ContactPerson");
        }
    }
}
