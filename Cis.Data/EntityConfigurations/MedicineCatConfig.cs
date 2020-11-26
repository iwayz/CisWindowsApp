using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class MedicineCatConfig : EntityTypeConfiguration<MedicineCat>
    {
        public MedicineCatConfig()
        {
            ToTable("CIS_MED_CAT");

            Property(e => e.MedicineCatCode)
                .HasColumnName("MED_CAT_CODE")
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();

            
        }
    }
}
