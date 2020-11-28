using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class LocationConfig : EntityTypeConfiguration<Location>
    {
        public LocationConfig()
        {
            Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.LocationType)
                .IsRequired();

            Property(e => e.ParentId)
                .IsRequired();

        }
    }
}