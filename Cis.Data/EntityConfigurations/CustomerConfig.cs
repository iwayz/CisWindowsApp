using Cis.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cis.Data
{
    public class CustomerConfig: EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            ToTable("CIS_CUSTOMER");

            Property(e => e.Name)
                .HasColumnName("NAME")
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

            Property(e => e.PostalCode)
                .HasColumnName("POSTAL_CODE")
                .IsOptional();

            Property(e => e.Phone)
                .HasColumnName("PHONE")
                .IsOptional();

            Property(e => e.Email)
                .HasColumnName("EMAIL")
                .IsOptional();

            Property(e => e.Npwp)
                .HasColumnName("NPWP")
                .IsOptional();

            Property(e => e.PharmacistName)
                .HasColumnName("PHARMACIST_NAME")
                .IsOptional();

            Property(e => e.SipaNo)
                .HasColumnName("SIPA_NO")
                .IsOptional();

            Property(e => e.SipaExpiredDate)
                .HasColumnName("SIPA_EXP_DATE")
                .IsRequired();

            Property(e => e.SiaNo)
                .HasColumnName("SIA_NO")
                .IsOptional();

            Property(e => e.OutletTypeId)
                .HasColumnName("OUTLET_TYPE_ID")
                .IsRequired();

            Property(e => e.SalesAreaId)
                .HasColumnName("SALES_AREA_ID")
                .IsRequired();


            HasIndex(e => e.Name)
                .HasName("IX_CUST_NAME");

            //builder.HasOne(e => e.SalesArea)
            //    .WithMany(e => e.Customers)
            //    .HasForeignKey(e => e.SalesAreaId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasOne(e => e.OutletType)
            //    .WithMany(o => o.Customers)
            //    .HasForeignKey(e => e.OutletTypeId)
            //    .OnDelete(DeleteBehavior.Restrict);


            // .HasColumnName("SIPA_EXP_DATE")
            //    .HasDefaultValue("1900-01-01")
        }
    }
}
