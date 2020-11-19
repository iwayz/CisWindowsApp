using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("ROLE");

            builder.Property(r => r.RoleCode)
                    .HasColumnName("ROLE_CODE")
                    .HasMaxLength(50)
                    .IsRequired();

            builder.Property(r => r.Description)
                    .HasColumnName("DESC")
                    .IsRequired();

            new BaseEntityConfig<Role>().Configure(ref builder);


            builder
                .HasIndex(r => r.RoleCode)
                .IsUnique()
                .HasName("IX_ROLE_CODE");
        }
    }
}
