using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class BatchConfig : EntityTypeConfiguration<Batch>
    {
        public BatchConfig()
        {
            ToTable("CIS_BATCH");

            Property(e => e.BatchCode)
                .HasColumnName("BATCH_CODE")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Quantity)
                .HasColumnName("QTY")
                .IsRequired();

            Property(e => e.EntryDate)
                .HasColumnName("ENTRY_DATE")
                .IsRequired();

            Property(e => e.ExpiredDate)
                .HasColumnName("EXPIRED_DATE")
                .IsRequired();

            Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .HasMaxLength(36)
                .IsRequired();

            HasIndex(b => b.BatchCode)
                .IsUnique()
                .HasName("IX_BATCH_CODE");

        }
    }
}
