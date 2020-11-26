using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class RoleConfig : EntityTypeConfiguration<Role>
    {
        public RoleConfig()
        {
            ToTable("CIS_ROLE");

            Property(e => e.RoleCode)
                .HasColumnName("ROLE_CODE")
                .HasMaxLength(20)
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
