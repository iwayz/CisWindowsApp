using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cis.Data.Configurations
{
    public class SalesmanConfig : IEntityTypeConfiguration<Salesman>
    {
        public void Configure(EntityTypeBuilder<Salesman> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
