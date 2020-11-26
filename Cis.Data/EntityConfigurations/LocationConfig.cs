using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class LocationConfig : EntityTypeConfiguration<Location>
    {
        public LocationConfig()
        {
            ToTable("CIS_LOCATION");

            Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.LocationType)
                .HasColumnName("LOC_TYPE")
                .IsRequired();

            Property(e => e.ParentId)
                .HasColumnName("PARENT_LOC_ID")
                .IsRequired();

           
           HasIndex(e => e.Name)
                .HasName("IX_LOC_NAME");
        }
    }
}