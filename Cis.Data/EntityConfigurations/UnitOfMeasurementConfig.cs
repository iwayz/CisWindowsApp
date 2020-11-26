using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class UnitOfMeasurementConfig : EntityTypeConfiguration<UnitOfMeasurement>
    {
        public UnitOfMeasurementConfig()
        {
            ToTable("CIS_UOM");

            Property(e => e.UomCode)
                .HasColumnName("UOM_CODE")
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();


        }
    }
}
