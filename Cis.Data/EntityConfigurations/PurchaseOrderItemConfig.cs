using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class PurchaseOrderItemConfig : EntityTypeConfiguration<PurchaseOrderItem>
    {
        public PurchaseOrderItemConfig()
        {
            Property(e => e.PurchaseOrderId)
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

            Property(e => e.ExpiredDate)
                .IsRequired();

            Property(e => e.Quantity)
                .IsRequired();

            Property(e => e.UomId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UomCode)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.Price)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.DiscountPercentage)
                .IsRequired();

            Property(e => e.TotalAmount)
                .HasPrecision(15, 5)
                .IsRequired();
        }
    }
}
