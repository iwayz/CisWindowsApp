using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class PermissionRoleConfig : EntityTypeConfiguration<PermissionRole>
    {
        public PermissionRoleConfig()
        {
            Property(e => e.RoleId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.PermisionId)
                .HasMaxLength(36)
                .IsRequired();

            HasIndex(e => new { e.RoleId, e.PermisionId })
                .IsUnique();

        }
    }
}
