using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class CustomerConfig: EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Address)
                .IsRequired();

            Property(e => e.ProvinceId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.DistrictId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.SubDistrictId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.PostalCode)
                .HasMaxLength(5)
                .IsOptional();

            Property(e => e.Phone)
                .IsOptional();

            Property(e => e.Email)
                .IsOptional();

            Property(e => e.Npwp)
                .IsOptional();

            Property(e => e.PharmacistName)
                .IsOptional();

            Property(e => e.SipaNo)
                .IsOptional();

            Property(e => e.SipaExpiredDate)
                .IsRequired();

            Property(e => e.SiaNo)
                .IsOptional();

            Property(e => e.OutletTypeId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.SalesAreaId)
                .IsRequired();

        }
    }
}
