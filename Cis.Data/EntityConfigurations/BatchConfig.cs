using Cis.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Cis.Data
{
    public class BatchConfig : EntityTypeConfiguration<Batch>
    {
        public BatchConfig()
        {
            ToTable("CIS_BATCH");

            //new BaseEntityConfig<Batch>().SetCommonProperties();

            Property(e => e.BatchCode)
                .HasColumnName("BATCH_CODE")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Quantity)
                .HasColumnName("QTY")
                .IsRequired();

            Property(e => e.EntryDate)
                .HasColumnName("ENTRY_DATE")
                .IsRequired();

            Property(e => e.ExpiredDate)
                .HasColumnName("EXPIRED_DATE")
                .IsRequired();

            Property(e => e.ProductId)
                .HasColumnName("PRODUCT_ID")
                .IsRequired();

            HasIndex(b => b.BatchCode)
                .IsUnique()
                .HasName("IX_BATCH_CODE");

            //builder
            //    .HasOne(b => b.Product)
            //    .WithMany(p => p.Batches)
            //    .HasForeignKey(b => b.ProductId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
