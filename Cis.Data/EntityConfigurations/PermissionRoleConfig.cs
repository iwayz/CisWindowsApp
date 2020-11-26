using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class PermissionRoleConfig : EntityTypeConfiguration<PermissionRole>
    {
        public PermissionRoleConfig()
        {
            ToTable("CIS_PERMISSION_ROLE");

            Property(e => e.RoleId)
                .HasColumnName("ROLE_ID")
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.AccessUnit)
                .HasColumnName("ACCESS_UNIT")
                .HasMaxLength(100)
                .IsRequired();

            HasIndex(e => new { e.RoleId, e.AccessUnit})
                .IsUnique()
                .HasName("IX_ROLE_ID_ACCESS_UNIT");

            //builder
            //    .HasOne(e => e.Role)
            //    .WithMany(e => e.PermissionRoles)
            //    .HasForeignKey(e => e.RoleId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
