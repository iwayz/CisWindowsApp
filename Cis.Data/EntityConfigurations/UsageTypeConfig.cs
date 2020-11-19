using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class UsageTypeConfig : IEntityTypeConfiguration<UsageType>
    {
        public void Configure(EntityTypeBuilder<UsageType> builder)
        {
            builder.ToTable("USAGE_TYPE");

            builder.Property(s => s.Description)
                   .HasColumnName("DESC")
                   .IsRequired();

            new BaseEntityConfig<UsageType>().Configure(ref builder);

        }
    }
}
