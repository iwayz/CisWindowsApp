using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        public RoleConfig()
        {
            ToTable("CIS_ROLE");

            Property(e => e.RoleCode)
                .HasColumnName("ROLE_CODE")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();


            HasIndex(e => e.RoleCode)
                .IsUnique()
                .HasName("IX_ROLE_CODE");
        }
    }
}
