using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class UserRoleConfig : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfig()
        {
            Property(e => e.RoleId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UserId)
                .HasMaxLength(36)
                .IsRequired();


            HasIndex(u => new { u.RoleId, u.UserId })
                .IsUnique();
        }
    }
}
