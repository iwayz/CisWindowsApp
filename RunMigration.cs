using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;

class RunMigration
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Running EF6 migrations...");
            var config = new Cis.Data.Migrations.Configuration();
            config.TargetDatabase = new DbConnectionInfo(
                "Server=.;Database=CIS_POS;User Id=capung;Password=admin;",
                "System.Data.SqlClient");
            var migrator = new DbMigrator(config);
            migrator.Update();
            Console.WriteLine("Done. Migrations applied successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine(ex.ToString());
            Environment.Exit(1);
        }
    }
}
