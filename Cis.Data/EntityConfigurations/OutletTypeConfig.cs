using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class OutletTypeConfig : EntityTypeConfiguration<OutletType>
    {
        public OutletTypeConfig()
        {
            Property(e => e.OutletTypeCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsRequired();

            HasIndex(e => e.OutletTypeCode)
               .IsUnique();
        }
    }
}
