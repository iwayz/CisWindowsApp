using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class OutletTypeConfig : EntityTypeConfiguration<OutletType>
    {
        public OutletTypeConfig()
        {
            ToTable("CIS_OUTLET_TYPE");

            Property(e => e.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();

        }
    }
}
