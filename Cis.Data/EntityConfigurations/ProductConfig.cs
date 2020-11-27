﻿using Cis.Model;
using System.Data.Entity.ModelConfiguration;


namespace Cis.Data
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            ToTable("CIS_PRODUCT");

            Property(e => e.ProductCode)
                .HasColumnName("PRODUCT_CODE")
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.ProductName)
                .HasColumnName("PRODUCT_NAME")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Price)
                .HasColumnName("PRICE")
                .IsRequired();

            Property(e => e.PriceDecreeDate)
                .HasColumnName("PRICE_DEC_DATE")
                .IsRequired();

            Property(e => e.Discount)
                .HasColumnName("DISCOUNT")
                .IsRequired();

            Property(e => e.RestockLevel)
                .HasColumnName("RESTOCK_LEVEL")
                .IsRequired();

            Property(e => e.UnitId)
                .HasColumnName("UNIT_ID")
                .IsRequired();

            Property(e => e.MedicineCatId)
                .HasColumnName("MED_CAT_ID")
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.UsageTypeId)
                .HasColumnName("USAGE_TYPE_ID")
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.PrincipalId)
                .HasColumnName("PRINCIPAL_ID")
                .HasMaxLength(36)
                .IsRequired();

            
            HasIndex(e => e.ProductCode)
                .IsUnique()
                .HasName("IX_PRODUCT_CODE");

            HasIndex(e => e.ProductName)
                .HasName("IX_PRODUCT_NAME");

                //.HasColumnName("PRICE")
                //.HasDefaultValue(0)

                //.HasColumnName("PRICE_DEC_DATE")
                //.HasDefaultValue("1900-01-01")

                //.HasColumnName("DISCOUNT")
                //.HasDefaultValue(0)

                //.HasColumnName("RESTOCK_LEVEL")
                //.HasDefaultValue(0)

        }
    }
}
