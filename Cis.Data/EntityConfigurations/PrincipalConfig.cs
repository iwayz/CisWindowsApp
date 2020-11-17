using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class PrincipalConfig : IEntityTypeConfiguration<Principal>
    {
        public void Configure(EntityTypeBuilder<Principal> builder)
        {
            builder.ToTable("PRINCIPAL");
            
            builder.Property(p => p.Name)
                    .HasColumnName("NAME")
                    .IsRequired();

            builder.Property(p => p.Address)
                    .HasColumnName("ADDRESS")
                    .IsRequired();

            builder.Property(p => p.LocationId)
                    .HasColumnName("LOC_ID")
                    .IsRequired();

            builder.Property(p => p.Phone)
                    .HasColumnName("PHONE")
                    .IsRequired(false);

            builder.Property(p => p.Email)
                    .HasColumnName("EMAIL")
                    .IsRequired(false);

            new BaseEntityConfig<Principal>().SetAuditFields(ref builder);
            
            
            builder.HasKey(p => p.Id);

        }
    }
}
