using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class StockOpnameConfig : EntityTypeConfiguration<StockOpname>
    {
        public StockOpnameConfig()
        {
            Property(e => e.OpnameNumber)
                .HasMaxLength(20)
                .IsRequired();

            Property(e => e.OpnameType)
                .IsRequired();

            Property(e => e.OpnameDate)
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

            HasIndex(e => e.OpnameNumber)
                .IsUnique();
        }
    }
}
