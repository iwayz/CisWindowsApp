using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    class PermissionRoleConfig : IEntityTypeConfiguration<PermissionRole>
    {
        public void Configure(EntityTypeBuilder<PermissionRole> builder)
        {
            builder.ToTable("PERMISSION_ROLE");

            builder.Property(p => p.RoleId)
                    .HasColumnName("ROLE_ID")
                    .HasMaxLength(36)
                    .IsRequired();

            builder.Property(p => p.AccessUnit)
                    .HasColumnName("ACCESS_UNIT")
                    .HasMaxLength(100)
                    .IsRequired();

            new BaseEntityConfig<PermissionRole>().Configure(ref builder);


            builder
                .HasIndex(p => new { p.RoleId, p.AccessUnit})
                .IsUnique()
                .HasName("IX_ROLE_ID_ACCESS_UNIT");

            builder
                .HasOne(p => p.Role)
                .WithMany(p => p.PermissionRoles)
                .HasForeignKey(p => p.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
