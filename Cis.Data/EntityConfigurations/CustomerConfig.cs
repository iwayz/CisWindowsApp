using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class CustomerConfig: EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            ToTable("CIS_CUSTOMER");

            Property(e => e.CustomerName)
                .HasColumnName("CUSTOMER_NAME")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .IsRequired();

            Property(e => e.ProvinceId)
                .HasColumnName("PROVINCE_ID")
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.DistrictId)
                .HasColumnName("DISTRICT_ID")
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.SubDistrictId)
                .HasColumnName("SUBDISTRICT_ID")
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.PostalCode)
                .HasColumnName("POSTAL_CODE")
                .HasMaxLength(5)
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
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.SalesAreaId)
                .HasColumnName("SALES_AREA_ID")
                .IsRequired();


            HasIndex(e => e.CustomerName)
                .HasName("IX_CUST_NAME");

            // .HasColumnName("SIPA_EXP_DATE")
            //    .HasDefaultValue("1900-01-01")
        }
    }
}
