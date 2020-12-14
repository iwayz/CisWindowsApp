﻿using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class SalesOrderItemConfig: EntityTypeConfiguration<SalesOrderItem>
    {
        public SalesOrderItemConfig()
        {
            Property(e => e.SalesOrderId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.ProductId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.ProductName)
                .IsRequired();

            Property(e => e.BatchId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.BatchCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.ExpiredDate)
                .IsRequired();

            Property(e => e.Quantity)
                .IsRequired();

            Property(e => e.UomId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UomCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Price)
                .IsRequired();

            Property(e => e.DiscountPercentage)
                .IsRequired();

            Property(e => e.TotalAmount)
                .IsRequired();


            HasIndex(e => new { e.SalesOrderId, e.ProductId, e.BatchId })
                .IsUnique();
        }
    }
}