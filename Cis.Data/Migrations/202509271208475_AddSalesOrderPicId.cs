namespace Cis.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddSalesOrderPicId : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                IF NOT EXISTS (
                    SELECT 1 
                    FROM sys.columns
                    WHERE Name = N'PersonInChargeId'
                      AND Object_ID = Object_ID(N'[dbo].[SalesOrder]')
                )
                BEGIN
                    ALTER TABLE [dbo].[SalesOrder]
                    ADD PersonInChargeId UNIQUEIDENTIFIER NULL;
                END
            ");
        }

        public override void Down()
        {
            Sql("ALTER TABLE [dbo].[SalesOrder] DROP COLUMN [PersonInChargeId]");
        }
    }
}
