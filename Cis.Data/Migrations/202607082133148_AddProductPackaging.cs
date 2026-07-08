namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddProductPackaging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductPackaging",
                c => new
                {
                    Id = c.String(nullable: false, maxLength: 36),
                    ProductId = c.String(nullable: false, maxLength: 36),
                    UnitId = c.String(nullable: false, maxLength: 36),
                    ConversionQty = c.Int(nullable: false),
                    CreatedBy = c.String(nullable: false, maxLength: 36),
                    CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    ModifiedBy = c.String(nullable: false, maxLength: 36),
                    ModifiedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.ProductId)
                .ForeignKey("dbo.UnitOfMeasurement", t => t.UnitId)
                .Index(t => new { t.ProductId, t.UnitId }, unique: true)
                .Index(t => t.UnitId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.ProductPackaging", "UnitId", "dbo.UnitOfMeasurement");
            DropForeignKey("dbo.ProductPackaging", "ProductId", "dbo.Product");
            DropIndex("dbo.ProductPackaging", new[] { "UnitId" });
            DropIndex("dbo.ProductPackaging", new[] { "ProductId", "UnitId" });
            DropTable("dbo.ProductPackaging");
        }
    }
}
