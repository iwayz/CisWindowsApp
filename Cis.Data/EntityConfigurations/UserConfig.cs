using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USER");

            builder.Property(s => s.Username)
                       .HasColumnName("USER_NAME")
                       .IsRequired();

            builder.Property(s => s.Password)
                       .HasColumnName("PASSWORD")
                       .IsRequired();

            builder.Property(s => s.FullName)
                       .HasColumnName("FULL_NAME")
                       .IsRequired();

            new BaseEntityConfig<User>().Configure(ref builder);

        }
    }
}
