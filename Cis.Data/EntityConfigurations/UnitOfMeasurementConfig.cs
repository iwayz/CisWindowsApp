using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cis.Data
{
    public class UnitOfMeasurementConfig : IEntityTypeConfiguration<UnitOfMeasurement>
    {
        public void Configure(EntityTypeBuilder<UnitOfMeasurement> builder)
        {
            builder.ToTable("UOM");

            builder.Property(u => u.UomCode)
                   .HasColumnName("UOM_CODE")
                   .IsRequired();

            builder.Property(s => s.Description)
                   .HasColumnName("DESC")
                   .IsRequired();

            new BaseEntityConfig<UnitOfMeasurement>().SetAuditFields(ref builder);


            builder.HasKey(f => f.Id);

            
        }
    }
}
