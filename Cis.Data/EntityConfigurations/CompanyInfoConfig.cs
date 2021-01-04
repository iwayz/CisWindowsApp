using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class CompanyInfoConfig : EntityTypeConfiguration<CompanyInfo>
    {
        public CompanyInfoConfig()
        {
            Property(e => e.Key)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Value)
                .IsRequired();

            HasIndex(e => e.Key)
               .IsUnique();
        }
    }
}
