using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

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
            
            //builder
            //    .HasOne(e => e.Role)
            //    .WithMany(e => e.UserRoles)
            //    .HasForeignKey(e => e.RoleId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .HasOne(e => e.User)
            //    .WithMany(e => e.UserRoles)
            //    .HasForeignKey(e => e.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
