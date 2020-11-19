using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class BatchConfig : IEntityTypeConfiguration<Batch>
    {
        public void Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.ToTable("BATCH");

            builder.Property(b => b.BatchCode)
                    .HasColumnName("BATCH_CODE")
                    .HasMaxLength(100)
                    .IsRequired();

            builder.Property(b => b.Quantity)
                    .HasColumnName("QTY")
                    .IsRequired();

            builder.Property(b => b.EntryDate)
                    .HasColumnName("ENTRY_DATE")
                    .IsRequired();

            builder.Property(b => b.ExpiredDate)
                    .HasColumnName("EXPIRED_DATE")
                    .IsRequired();

            builder.Property(b => b.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .IsRequired();

            new BaseEntityConfig<Batch>().Configure(ref builder);


            builder
                .HasIndex(b => b.BatchCode)
                .IsUnique()
                .HasName("IX_BATCH_CODE");

            builder
                .HasOne(b => b.Product)
                .WithMany(p => p.Batches)
                .HasForeignKey(b => b.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
