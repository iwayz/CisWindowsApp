using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
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
                .HasColumnName("DESCRIPTION")
                .IsRequired();

            new BaseEntityConfig<UnitOfMeasurement>().Configure(ref builder);

        }
    }
}
