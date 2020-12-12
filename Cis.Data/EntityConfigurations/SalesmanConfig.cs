using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class SalesmanConfig : EntityTypeConfiguration<Salesman>
    {
        public SalesmanConfig()
        {
            Property(e => e.SalesmanCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.FullName)
                .IsRequired();

            Property(e => e.Gender)
                .IsRequired();

            Property(e => e.Address)
                .IsOptional();

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

            HasIndex(e => e.SalesmanCode)
               .IsUnique();
        }
    }
}
