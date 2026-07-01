namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ConvertStockQuantitiesToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StockCard", "QtyOnHand", c => c.Int(nullable: false));
            AlterColumn("dbo.StockCard", "QtyReserved", c => c.Int(nullable: false));
            AlterColumn("dbo.StockMovement", "Qty", c => c.Int(nullable: false));
            AlterColumn("dbo.StockTransferItem", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.StockOpnameItem", "QtySystem", c => c.Int(nullable: false));
            AlterColumn("dbo.StockOpnameItem", "QtyPhysical", c => c.Int(nullable: false));
            AlterColumn("dbo.StockOpnameItem", "Difference", c => c.Int(nullable: false));
            AlterColumn("dbo.StockAdjustmentItem", "QtyBefore", c => c.Int(nullable: false));
            AlterColumn("dbo.StockAdjustmentItem", "QtyAdjustment", c => c.Int(nullable: false));
            AlterColumn("dbo.StockAdjustmentItem", "QtyAfter", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.StockAdjustmentItem", "QtyAfter", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockAdjustmentItem", "QtyAdjustment", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockAdjustmentItem", "QtyBefore", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockOpnameItem", "Difference", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockOpnameItem", "QtyPhysical", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockOpnameItem", "QtySystem", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockTransferItem", "Quantity", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockMovement", "Qty", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockCard", "QtyReserved", c => c.Decimal(nullable: false, precision: 15, scale: 5));
            AlterColumn("dbo.StockCard", "QtyOnHand", c => c.Decimal(nullable: false, precision: 15, scale: 5));
        }
    }
}