using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class SalesmanConfig : EntityTypeConfiguration<Salesman>
    {
        public SalesmanConfig()
        {
            ToTable("CIS_SALESMAN");

            Property(e => e.SalesmanCode)
                .HasColumnName("SALESMAN_CODE")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.FullName)
                .HasColumnName("FULL_NAME")
                .IsRequired();

            Property(e => e.Gender)
                .HasColumnName("GENDER")
                .IsRequired();

            Property(e => e.Address)
                .HasColumnName("ADDRESS")
                .IsOptional();

            Property(p => p.ProvinceId)
                .HasColumnName("PROVINCE_ID")
                .HasMaxLength(36)
                .IsRequired();

            Property(p => p.DistrictId)
                .HasColumnName("DISTRICT_ID")
                .HasMaxLength(36)
                .IsRequired();

            Property(p => p.SubDistrictId)
                .HasColumnName("SUBDISTRICT_ID")
                .HasMaxLength(36)
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

        }
    }
}
