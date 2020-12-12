using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class BatchConfig : EntityTypeConfiguration<Batch>
    {
        public BatchConfig()
        {
            Property(e => e.BatchCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Quantity)
                .IsRequired();

            Property(e => e.EntryDate)
                .IsRequired();

            Property(e => e.ExpiredDate)
                .IsRequired();

            Property(e => e.ProductId)
                .HasMaxLength(36)
                .IsRequired();

            HasIndex(e => e.BatchCode)
                .IsUnique();
        }
    }
}
