using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockMovementConfig : EntityTypeConfiguration<StockMovement>
    {
        public StockMovementConfig()
        {
            Property(e => e.MovementDate)
                .IsRequired();

            Property(e => e.MovementType)
                .IsRequired();

            Property(e => e.Direction)
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

            Property(e => e.Qty)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.ReferenceType)
                .HasMaxLength(50)
                .IsOptional();

            Property(e => e.ReferenceId)
                .HasMaxLength(36)
                .IsOptional();

            Property(e => e.Remarks)
                .IsOptional();
        }
    }
}
