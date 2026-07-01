namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedInventoryPermissionCode : DbMigration
    {
        public override void Up()
        {
            string Row(string id, string code, string desc, int type) =>
                $"IF NOT EXISTS (SELECT 1 FROM [dbo].[Permission] WHERE [PermissionCode] = '{code}')" +
                $" INSERT INTO [dbo].[Permission] ([Id],[PermissionCode],[Description],[PermisionType],[CreatedBy],[CreatedAt],[ModifiedBy],[ModifiedAt])" +
                $" VALUES ('{id}','{code}','{desc}',{type},'SCRIPT',GETDATE(),'SCRIPT',GETDATE())";

            // Transaction (type 2)
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7801", "202", "Purchase Return", 2));
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7802", "203", "Sales Return",    2));

            // Reporting (type 3)
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7805", "302", "Stock Movement",  3));
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7806", "303", "Stock Card",      3));

            // Inventory (type 4)
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7807", "400", "Stock Opname",    4));
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7808", "401", "Transfer Stock",  4));
            Sql(Row("A1B2C3D4-E5F6-7890-AB12-CD3456EF7809", "402", "Adjust Stock",    4));
        }

        public override void Down()
        {
            Sql("DELETE FROM [dbo].[Permission] WHERE [Id] IN (" +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7801'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7802'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7803'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7804'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7805'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7806'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7807'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7808'," +
                "'A1B2C3D4-E5F6-7890-AB12-CD3456EF7809')");
        }
    }
}
