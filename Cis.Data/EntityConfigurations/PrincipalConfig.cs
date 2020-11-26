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
            ToTable("CIS_PRINCIPAL");
            
            Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .IsRequired();

            Property(e => e.ProvinceId)
                .HasColumnName("PROVINCE_ID")
                .IsRequired();

            Property(e => e.DistrictId)
                .HasColumnName("DISTRICT_ID")
                .IsRequired();

            Property(e => e.SubDistrictId)
                .HasColumnName("SUBDISTRICT_ID")
                .IsRequired();

            Property(e => e.Phone)
                .HasColumnName("PHONE")
                .IsOptional();

            Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsOptional();


            HasIndex(e => e.Name)
                .HasName("IX_PRINCIPAL_NAME");

        }
    }
}
