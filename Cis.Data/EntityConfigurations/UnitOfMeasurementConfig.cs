using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class UnitOfMeasurementConfig : EntityTypeConfiguration<UnitOfMeasurement>
    {
        public UnitOfMeasurementConfig()
        {
            ToTable("CIS_UOM");

            Property(e => e.UomCode)
                .HasColumnName("UOM_CODE")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();

        }
    }
}
