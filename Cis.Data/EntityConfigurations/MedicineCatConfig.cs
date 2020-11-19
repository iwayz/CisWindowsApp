using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class MedicineCatConfig : IEntityTypeConfiguration<MedicineCat>
    {
        public void Configure(EntityTypeBuilder<MedicineCat> builder)
        {
            builder.ToTable("MED_CAT");

            builder.Property(m => m.Description)
                    .HasColumnName("DESC")
                    .IsRequired();

            new BaseEntityConfig<MedicineCat>().Configure(ref builder);
            
        }
    }
}
