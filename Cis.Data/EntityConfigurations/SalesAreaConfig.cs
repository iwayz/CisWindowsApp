using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class SalesAreaConfig : EntityTypeConfiguration<SalesArea>
    {
        public SalesAreaConfig()
        {
            Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsOptional();

        }
    }
}
