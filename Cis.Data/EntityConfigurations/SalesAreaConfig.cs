using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class SalesAreaConfig : IEntityTypeConfiguration<SalesArea>
    {
        public void Configure(EntityTypeBuilder<SalesArea> builder)
        {
            builder.ToTable("SALES_AREA");

            builder.Property(s => s.AreaName)
                   .HasColumnName("AREA_NAME")
                   .IsRequired();

            builder.Property(s => s.Description)
                   .HasColumnName("DESC")
                   .IsRequired(false);

            new BaseEntityConfig<SalesArea>().Configure(ref builder);

        }
    }
}
