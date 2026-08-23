namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPurchaseOrderExtraDiscount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrder", "ExtraDiscountAmount", c => c.Decimal(nullable: false, precision: 15, scale: 5, defaultValue: 0m));
        }

        public override void Down()
        {
            DropColumn("dbo.PurchaseOrder", "ExtraDiscountAmount");
        }
    }
}
