using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cis.Data
{
    public class OutletTypeConfig : IEntityTypeConfiguration<OutletType>
    {
        public void Configure(EntityTypeBuilder<OutletType> builder)
        {
            builder.ToTable("OUTLET_TYPE");

            builder.Property(o => o.Description)
                    .HasColumnName("DESC")
                    .IsRequired();

            new BaseEntityConfig<OutletType>().SetAuditFields(ref builder);
            
            builder.HasKey(o => o.Id);
        }
    }
}
