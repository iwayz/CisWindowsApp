using Cis.Model;
using System.Data.Entity.ModelConfiguration;
namespace Cis.Data.EntityConfigurations
{
    public class TermOfPaymentConfig: EntityTypeConfiguration<TermOfPayment>
    {
        public TermOfPaymentConfig()
        {
            Property(e => e.TermCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsOptional();

            HasIndex(e => e.TermCode)
               .IsUnique();
        }
    }
}
