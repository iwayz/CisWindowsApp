using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class ProductPackagingConfig : EntityTypeConfiguration<ProductPackaging>
    {
        public ProductPackagingConfig()
        {
            Property(e => e.ProductId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UnitId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.ConversionQty)
                .IsRequired();

            HasIndex(e => new { e.ProductId, e.UnitId })
                .IsUnique();
        }
    }
}
