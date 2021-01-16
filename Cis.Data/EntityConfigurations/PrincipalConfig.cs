using Cis.Model;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.EntityConfigurations
{
    public class PrincipalConfig : EntityTypeConfiguration<Principal>
    {
        public PrincipalConfig()
        {
            Property(e => e.PrincipalCode)
                .HasMaxLength(50)
                .IsRequired(); 
            
            Property(e => e.PrincipalName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Address)
                .IsRequired();

            Property(e => e.ProvinceId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.DistrictId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.SubDistrictId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.Phone)
                .IsOptional();

            Property(e => e.Email)
                .IsOptional();

            HasIndex(e => e.PrincipalCode);
        }
    }
}
