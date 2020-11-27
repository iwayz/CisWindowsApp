using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class SalesAreaConfig : EntityTypeConfiguration<SalesArea>
    {
        public SalesAreaConfig()
        {
            ToTable("CIS_SALES_AREA");

            Property(e => e.AreaCode)
                .HasColumnName("AREA_CODE")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsOptional();


        }
    }
}
