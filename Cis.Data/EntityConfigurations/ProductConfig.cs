using Cis.Model;
using System.Data.Entity.ModelConfiguration;


namespace Cis.Data
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Price)
                .IsRequired();

            Property(e => e.PriceDecreeDate)
                .IsRequired();

            Property(e => e.Discount)
                .IsRequired();

            Property(e => e.RestockLevel)
                .IsRequired();

            Property(e => e.UnitId)
                .IsRequired();

            Property(e => e.MedicineCatId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UsageTypeId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.PrincipalId)
                .HasMaxLength(36)
                .IsRequired();


            HasIndex(e => e.ProductCode)
                .IsUnique();

            HasIndex(e => e.ProductName);
        }
    }
}
