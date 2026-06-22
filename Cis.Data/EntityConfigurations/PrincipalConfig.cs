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

            Property(e => e.Phone)
                .HasMaxLength(20)
                .IsOptional();

            Property(e => e.Email)
                .HasMaxLength(100)
                .IsOptional();

            Property(e => e.ContactPerson)
                .HasMaxLength(100)
                .IsOptional();

            Property(e => e.Npwp)
                .HasMaxLength(30)
                .IsOptional();

            HasIndex(e => e.PrincipalCode);
        }
    }
}
