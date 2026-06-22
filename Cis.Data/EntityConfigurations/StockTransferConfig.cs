using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockTransferConfig : EntityTypeConfiguration<StockTransfer>
    {
        public StockTransferConfig()
        {
            Property(e => e.TransferNumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.TransferType)
                .IsRequired();

            Property(e => e.BranchName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.TransferDate)
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

            HasIndex(e => e.TransferNumber)
                .IsUnique();
        }
    }
}
