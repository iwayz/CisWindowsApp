using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data.EntityConfigurations
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            Property(e => e.Username)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Password)
                .IsRequired();

            Property(e => e.FullName)
                .IsRequired();

            HasIndex(e => e.Username)
               .IsUnique();
        }
    }
}
