using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class SalesReturnConfig : EntityTypeConfiguration<SalesReturn>
    {
        public SalesReturnConfig()
        {
            Property(e => e.ReturnNumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.SalesOrderId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.SalesNo)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.CustomerId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.CustomerName)
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
