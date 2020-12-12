using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class PermissionConfig: EntityTypeConfiguration<Permission>
    {
        public PermissionConfig()
        {
            Property(e => e.PermissionCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.PermisionType)
                .IsRequired();

            HasIndex(e => e.PermissionCode)
               .IsUnique();
        }
    }
}
