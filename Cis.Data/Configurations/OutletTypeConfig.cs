using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cis.Data.Configurations
{
    public class OutletTypeConfig : IEntityTypeConfiguration<OutletType>
    {
        public void Configure(EntityTypeBuilder<OutletType> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
