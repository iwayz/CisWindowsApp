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
                    .HasMaxLength(100)
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

            new BaseEntityConfig<Principal>().Configure(ref builder);

            builder
                .HasIndex(p => p.Name)
                .HasName("IX_PRINCIPAL_NAME");

            builder.HasOne(p => p.Location)
                .WithMany(l => l.Principals)
                .HasForeignKey(p => p.LocationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
