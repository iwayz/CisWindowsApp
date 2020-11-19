using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cis.Data
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("LOCATION");

            builder.Property(l => l.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsRequired();

            builder.Property(l => l.LocationType)
                .HasColumnName("LOC_TYPE")
                .HasConversion<byte>()
                .IsRequired();

            builder.Property(l => l.ParentId)
                    .HasColumnName("PARENT_LOC_ID")
                    .IsRequired();

            new BaseEntityConfig<Location>().Configure(ref builder);


            builder
                .HasIndex(l => l.Name)
                .HasName("IX_LOC_NAME");
        }
    }
}