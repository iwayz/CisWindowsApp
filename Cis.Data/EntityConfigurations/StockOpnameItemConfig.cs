using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockOpnameItemConfig : EntityTypeConfiguration<StockOpnameItem>
    {
        public StockOpnameItemConfig()
        {
            Property(e => e.StockOpnameId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.ProductId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.BatchId)
                .HasMaxLength(36)
                .IsOptional();

            Property(e => e.BatchCode)
                .HasMaxLength(50)
                .IsOptional();

            Property(e => e.UomId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UomCode)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.QtySystem)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.QtyPhysical)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.Difference)
                .HasPrecision(15, 5)
                .IsRequired();
        }
    }
}
