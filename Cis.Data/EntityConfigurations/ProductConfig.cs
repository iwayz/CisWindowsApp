using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cis.Data
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCT");

            builder.Property(p => p.ProductCode)
                   .HasColumnName("PRODUCT_CODE")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(p => p.ProductName)
                   .HasColumnName("PRODUCT_NAME")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(p => p.Price)
                   .HasColumnName("PRICE")
                   .HasDefaultValue(0)
                   .IsRequired();

            builder.Property(p => p.PriceDecreeDate)
                   .HasColumnName("PRICE_DEC_DATE")
                   .HasDefaultValue("1900-01-01")
                   .IsRequired();

            builder.Property(p => p.Discount)
                   .HasColumnName("DISC")
                   .HasDefaultValue(0)
                   .IsRequired();

            builder.Property(p => p.RestockLevel)
                   .HasColumnName("RESTOCK_LVL")
                   .HasDefaultValue(0)
                   .IsRequired();

            builder.Property(p => p.UnitId)
                   .HasColumnName("UNIT_ID")
                   .IsRequired();

            builder.Property(p => p.MedicineCatId)
                   .HasColumnName("MED_CAT_ID")
                   .IsRequired();

            builder.Property(p => p.UsageTypeId)
                   .HasColumnName("USAGE_TYPE_ID")
                   .IsRequired();

            builder.Property(p => p.PrincipalId)
                   .HasColumnName("PRINCIPAL_ID")
                   .IsRequired();

            new BaseEntityConfig<Product>().Configure(ref builder);

            
            builder.HasIndex(p => p.ProductCode)
                .IsUnique()
                .HasName("IX_PRODUCT_CODE");

            builder
                .HasIndex(p => p.ProductName)
                .HasName("IX_PRODUCT_NAME");

            builder.HasOne(p => p.Unit)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UnitId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.MedicineCat)
                .WithMany(m => m.Products)
                .HasForeignKey(p => p.MedicineCatId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.UsageType)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.UsageTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Principal)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.PrincipalId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
