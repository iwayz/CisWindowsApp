using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockCardConfig : EntityTypeConfiguration<StockCard>
    {
        public StockCardConfig()
        {
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

            Property(e => e.QtyOnHand)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.QtyReserved)
                .HasPrecision(15, 5)
                .IsRequired();

            HasIndex(e => new { e.ProductId, e.BatchId })
                .IsUnique();
        }
    }
}
