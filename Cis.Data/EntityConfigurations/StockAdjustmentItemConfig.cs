using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockAdjustmentItemConfig : EntityTypeConfiguration<StockAdjustmentItem>
    {
        public StockAdjustmentItemConfig()
        {
            Property(e => e.StockAdjustmentId)
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

            Property(e => e.QtyBefore)
                .IsRequired();

            Property(e => e.QtyAdjustment)
                .IsRequired();

            Property(e => e.QtyAfter)
                .IsRequired();

            Property(e => e.Direction)
                .IsRequired();
        }
    }
}
