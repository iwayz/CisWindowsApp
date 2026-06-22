using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockAdjustmentConfig : EntityTypeConfiguration<StockAdjustment>
    {
        public StockAdjustmentConfig()
        {
            Property(e => e.AdjustmentNumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.AdjustmentDate)
                .IsRequired();

            Property(e => e.Reason)
                .IsRequired();

            Property(e => e.Notes)
                .IsOptional();

            Property(e => e.PostingStatus)
                .IsRequired();

            Property(e => e.UserId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.Username)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.StockOpnameId)
                .HasMaxLength(36)
                .IsOptional();

            HasIndex(e => e.AdjustmentNumber)
                .IsUnique();
        }
    }
}
