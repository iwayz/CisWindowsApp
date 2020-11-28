using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        public RoleConfig()
        {
            Property(e => e.RoleCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsRequired();


            HasIndex(e => e.RoleCode)
                .IsUnique();
        }
    }
}
