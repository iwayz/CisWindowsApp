namespace Cis.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserDescription : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE [dbo].[User] ADD [Description] NVARCHAR(MAX) NULL");
        }

        public override void Down()
        {
            Sql("ALTER TABLE [dbo].[User] DROP COLUMN [Description]");
        }
    }
}
