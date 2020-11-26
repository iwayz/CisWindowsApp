using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class SalesAreaConfig : EntityTypeConfiguration<SalesArea>
    {
        public SalesAreaConfig()
        {
            ToTable("CIS_SALES_AREA");

            Property(e => e.AreaCode)
                .HasColumnName("AREA_CODE")
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsOptional();


        }
    }
}
