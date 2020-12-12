namespace Cis.Data.Migrations
{
    using Cis.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Model;
    using System.Data.Entity.SqlServer;

    internal sealed class Configuration : DbMigrationsConfiguration<Cis.Data.CisDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(Cis.Data.CisDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }

    /// <summary>
    /// Custom SQL Server Migration Generator to set the default Value for column CreatedAt and ModifiedAt
    /// </summary>
    internal class CustomSqlServerMigrationSqlGenerator : SqlServerMigrationSqlGenerator
    {
        protected override void Generate(AddColumnOperation addColumnOperation)
        {
            SetCreatedModifiedAtColumn(addColumnOperation.Column);

            base.Generate(addColumnOperation);
        }

        protected override void Generate(CreateTableOperation createTableOperation)
        {
            SetCreatedModifiedAtColumn(createTableOperation.Columns);

            base.Generate(createTableOperation);
        }
        private static void SetCreatedModifiedAtColumn(IEnumerable<PropertyModel> columns)
        {
            foreach (var col in columns)
            {
                SetCreatedModifiedAtColumn(col);
            }
        }
        private static void SetCreatedModifiedAtColumn(PropertyModel column)
        {
            if (column.Name.Equals(nameof(BaseEntity.CreatedAt))
                || column.Name.Equals(nameof(BaseEntity.ModifiedAt))
                || column.Name.Contains("DATE"))
            {
                column.DefaultValue = DateTime.Parse("1900-01-01");
            }
        }
    }
}
