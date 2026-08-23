namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddPurchaseOrderRepresentative : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PurchaseOrder", "RepresentativeId", c => c.String(maxLength: 36));
            AddColumn("dbo.PurchaseOrder", "RepresentativeCode", c => c.String(maxLength: 20));
            CreateIndex("dbo.PurchaseOrder", "RepresentativeId");
            AddForeignKey("dbo.PurchaseOrder", "RepresentativeId", "dbo.Representative", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.PurchaseOrder", "RepresentativeId", "dbo.Representative");
            DropIndex("dbo.PurchaseOrder", new[] { "RepresentativeId" });
            DropColumn("dbo.PurchaseOrder", "RepresentativeCode");
            DropColumn("dbo.PurchaseOrder", "RepresentativeId");
        }
    }
}
