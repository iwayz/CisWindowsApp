using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class SalesmanConfig : IEntityTypeConfiguration<Salesman>
    {
        public void Configure(EntityTypeBuilder<Salesman> builder)
        {
            builder.ToTable("SALESMAN");

            builder.Property(s => s.ShortName)
                   .HasColumnName("SHORT_NAME")
                   .IsRequired();

            builder.Property(s => s.FullName)
                   .HasColumnName("FULL_NAME")
                   .IsRequired();

            builder.Property(s => s.Gender)
                   .HasColumnName("GENDER")
                   .HasConversion<int>()
                   .IsRequired();

            builder.Property(s => s.Address)
                   .HasColumnName("ADDRESS")
                   .IsRequired(false);

            builder.Property(s => s.LocationId)
                   .HasColumnName("LOC_ID")
                   .IsRequired();

            builder.Property(s => s.PostalCode)
                   .HasColumnName("POSTAL_CODE")
                   .IsRequired(false);

            builder.Property(s => s.Phone)
                   .HasColumnName("PHONE")
                   .IsRequired(false);

            builder.Property(s => s.Email)
                   .HasColumnName("EMAIL")
                   .IsRequired(false);

            new BaseEntityConfig<Salesman>().SetAuditFields(ref builder);
            
            
            builder.HasKey(f => f.Id);
            
        }
    }
}
