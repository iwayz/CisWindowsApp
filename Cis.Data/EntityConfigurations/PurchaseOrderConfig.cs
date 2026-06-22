using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class PurchaseOrderConfig : EntityTypeConfiguration<PurchaseOrder>
    {
        public PurchaseOrderConfig()
        {
            Property(e => e.PONumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.SupplierId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.SupplierName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.SupplierAddress)
                .IsOptional();

            Property(e => e.SupplierPhone)
                .HasMaxLength(20)
                .IsOptional();

            Property(e => e.OrderDate)
                .IsRequired();

            Property(e => e.ExpectedDate)
                .IsRequired();

            Property(e => e.ReceivedDate)
                .IsOptional();

            Property(e => e.SubTotalAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.TaxBaseAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.ValueAddedTaxAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.GrandTotalAmount)
                .HasPrecision(15, 5)
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

            HasIndex(e => e.PONumber)
                .IsUnique();
        }
    }
}
