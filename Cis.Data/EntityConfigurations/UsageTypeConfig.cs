using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class UsageTypeConfig : EntityTypeConfiguration<UsageType>
    {
        public UsageTypeConfig()
        {
            Property(e => e.UsageTypeCode)
                .HasMaxLength(50)
                .IsRequired(); 
            
            Property(e => e.Description)
                .IsRequired();


        }
    }
}
