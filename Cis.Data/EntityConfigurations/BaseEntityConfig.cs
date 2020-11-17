using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class BaseEntityConfig<T> where T: class
    {
        public void SetAuditFields(ref EntityTypeBuilder<T> builder)
        {
            builder.Property(nameof(BaseEntity.CreatedBy))
                .HasColumnName("CREATED_BY")
                .IsRequired();

            builder.Property(nameof(BaseEntity.CreatedAt))
                .HasColumnName("CREATED_AT")
                .IsRequired();

            builder.Property(nameof(BaseEntity.ModifiedBy))
                .HasColumnName("MODIFIED_BY")
                .IsRequired();

            builder.Property(nameof(BaseEntity.ModifiedAt))
                .HasColumnName("MODIFIED_AT")
                .IsRequired();
        }
    }
}
