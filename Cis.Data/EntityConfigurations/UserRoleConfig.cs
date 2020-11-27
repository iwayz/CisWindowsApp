using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class UserRoleConfig : EntityTypeConfiguration<UserRole>
    {
        public UserRoleConfig()
        {
            ToTable("CIS_USER_ROLE");

            Property(e => e.RoleId)
                .HasColumnName("ROLE_ID")
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UserId)
                .HasColumnName("USER_ID")
                .HasMaxLength(36)
                .IsRequired();


            HasIndex(u => new { u.RoleId, u.UserId})
                .IsUnique()
                .HasName("IX_USER_ROLE_ROLE_ID_USER_ID");
            
        }
    }
}
