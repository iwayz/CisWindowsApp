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
                   .IsRequired();

            builder.Property(p => p.ProductName)
                   .HasColumnName("PRODUCT_NAME")
                   .IsRequired();

            builder.Property(p => p.Price)
                   .HasColumnName("PRICE")
                   .IsRequired();

            builder.Property(p => p.PriceDecreeDate)
                   .HasColumnName("PRICE_DEC_DATE")
                   .IsRequired();

            builder.Property(p => p.Discount)
                   .HasColumnName("DISC")
                   .IsRequired();

            builder.Property(p => p.RestockLevel)
                   .HasColumnName("RESTOCK_LVL")
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

            new BaseEntityConfig<Product>().SetAuditFields(ref builder);

            
            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.ProductCode)
                .IsUnique()
                .HasName("IDX_PRODUCT_CODE");

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
