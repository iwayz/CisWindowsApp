using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class MedicineCatConfig : EntityTypeConfiguration<MedicineCat>
    {
        public MedicineCatConfig()
        {
            Property(e => e.MedicineCatCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Description)
                .IsRequired();

        }
    }
}
