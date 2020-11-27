using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class UsageTypeConfig : EntityTypeConfiguration<UsageType>
    {
        public UsageTypeConfig()
        {
            ToTable("CIS_USAGE_TYPE");

            Property(e => e.UsageTypeCode)
                .HasColumnName("USAGE_TYPE_CODE")
                .HasMaxLength(50)
                .IsRequired(); 
            
            Property(e => e.Description)
                .HasColumnName("DESCRIPTION")
                .IsRequired();


        }
    }
}
