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

            builder.Property(l => l.LocationCode)
                    .HasColumnName("LOC_CODE")
                    .IsRequired(); 
            
            builder.Property(l => l.Name)
                    .HasColumnName("NAME")
                    .IsRequired();

            builder.Property(l => l.LocationType)
                .HasColumnName("LOC_TYPE")
                .HasConversion<int>()
                .IsRequired();

            builder.Property(l => l.ParentId)
                    .HasColumnName("PARENT_LOC_ID")
                    .IsRequired();

            new BaseEntityConfig<Location>().SetAuditFields(ref builder);


            builder.HasKey(l => l.Id);

            //builder.HasOne(c => c.Parent)
            //    .WithMany(p => p.Children)
            //    .HasForeignKey(c => c.ParentId);
        }
    }
}