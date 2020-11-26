using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            ToTable("CIS_USER");

            Property(e => e.Username)
                .HasColumnName("USER_NAME")
                .IsRequired();

            Property(e => e.Password)
                .HasColumnName("PASSWORD")
                .IsRequired();

            Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsRequired();


        }
    }
}
