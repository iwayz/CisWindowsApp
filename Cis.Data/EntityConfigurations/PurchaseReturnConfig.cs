using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class PurchaseReturnConfig : EntityTypeConfiguration<PurchaseReturn>
    {
        public PurchaseReturnConfig()
        {
            Property(e => e.ReturnNumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.PurchaseOrderId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.PONumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.SupplierId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.SupplierName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.ReturnDate)
                .IsRequired();

            Property(e => e.Reason)
                .IsOptional();

            Property(e => e.TotalAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.PostingStatus)
                .IsRequired();

            Property(e => e.UserId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.Username)
                .HasMaxLength(50)
                .IsRequired();

            HasIndex(e => e.ReturnNumber)
                .IsUnique();
        }
    }
}
