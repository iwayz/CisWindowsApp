namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPurchaseOrderSupplierInvoiceInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrder", "SupplierInvoiceNumber", c => c.String(maxLength: 50));
            AddColumn("dbo.PurchaseOrder", "SupplierInvoiceDate", c => c.DateTime());
            AddColumn("dbo.PurchaseOrder", "TaxInvoiceNumber", c => c.String(maxLength: 50));
        }

        public override void Down()
        {
            DropColumn("dbo.PurchaseOrder", "TaxInvoiceNumber");
            DropColumn("dbo.PurchaseOrder", "SupplierInvoiceDate");
            DropColumn("dbo.PurchaseOrder", "SupplierInvoiceNumber");
        }
    }
}
