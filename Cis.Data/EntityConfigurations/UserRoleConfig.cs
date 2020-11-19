using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("USER_ROLE");

            builder.Property(u => u.RoleId)
                    .HasColumnName("ROLE_ID")
                    .HasMaxLength(36)
                    .IsRequired();

            builder.Property(u => u.UserId)
                    .HasColumnName("USER_ID")
                    .HasMaxLength(36)
                    .IsRequired();

            new BaseEntityConfig<UserRole>().Configure(ref builder);


            builder
                .HasIndex(u => new { u.RoleId, u.UserId})
                .IsUnique()
                .HasName("IX_USER_ROLE_ROLE_ID_USER_ID");

            builder
                .HasOne(u => u.Role)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
