using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class OutletTypeConfig : IEntityTypeConfiguration<OutletType>
    {
        public void Configure(EntityTypeBuilder<OutletType> builder)
        {
            builder.ToTable("OUTLET_TYPE");

            builder.Property(o => o.OutletCode)
                .HasColumnName("OUTLET_CODE")
                .IsRequired();

            builder.Property(o => o.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();

            new BaseEntityConfig<OutletType>().Configure(ref builder);
        }
    }
}
