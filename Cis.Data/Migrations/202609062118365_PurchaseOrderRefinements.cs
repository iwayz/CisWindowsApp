namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PurchaseOrderRefinements : DbMigration
    {
        public override void Up()
        {
            // PurchaseOrder: drop Estimasi Tiba, add Tgl. Faktur Pajak
            DropColumn("dbo.PurchaseOrder", "ExpectedDate");
            AddColumn("dbo.PurchaseOrder", "TaxInvoiceDate", c => c.DateTime());

            // PurchaseOrderItem: DiscountPercentage (%) -> DiscountAmount (Rp)
            AddColumn("dbo.PurchaseOrderItem", "DiscountAmount", c => c.Decimal(nullable: false, precision: 15, scale: 5, defaultValue: 0m));

            // Backfill: DiscountAmount = Quantity * Price * (DiscountPercentage / 100)
            Sql(@"UPDATE [dbo].[PurchaseOrderItem]
                  SET DiscountAmount = ROUND(CAST(Quantity AS decimal(18,5)) * Price * (CAST(DiscountPercentage AS decimal(18,5)) / 100.0), 5)");

            DropColumn("dbo.PurchaseOrderItem", "DiscountPercentage");
        }

        public override void Down()
        {
            AddColumn("dbo.PurchaseOrderItem", "DiscountPercentage", c => c.Single(nullable: false));

            // Best-effort reverse backfill: DiscountPercentage = DiscountAmount / (Quantity * Price) * 100
            Sql(@"UPDATE [dbo].[PurchaseOrderItem]
                  SET DiscountPercentage = CAST(
                      CASE WHEN Quantity = 0 OR Price = 0 THEN 0
                           ELSE (DiscountAmount / (CAST(Quantity AS decimal(18,5)) * Price)) * 100.0
                      END AS float)");

            DropColumn("dbo.PurchaseOrderItem", "DiscountAmount");

            DropColumn("dbo.PurchaseOrder", "TaxInvoiceDate");
            AddColumn("dbo.PurchaseOrder", "ExpectedDate", c => c.DateTime(nullable: false, defaultValueSql: "GETDATE()"));
        }
    }
}
