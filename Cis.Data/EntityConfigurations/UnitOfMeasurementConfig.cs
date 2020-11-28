using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class UnitOfMeasurementConfig : EntityTypeConfiguration<UnitOfMeasurement>
    {
        public UnitOfMeasurementConfig()
        {
            Property(e => e.UomCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsRequired();

        }
    }
}
