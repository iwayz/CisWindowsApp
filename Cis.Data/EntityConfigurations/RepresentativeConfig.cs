using Cis.Model;
using System.Data.Entity.ModelConfiguration;
namespace Cis.Data.EntityConfigurations
{
    public class RepresentativeConfig : EntityTypeConfiguration<Representative>
    {
        public RepresentativeConfig()
        {
            Property(e => e.RepresentativeCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsOptional();

            HasIndex(e => e.RepresentativeCode)
               .IsUnique();
        }
    }
}
