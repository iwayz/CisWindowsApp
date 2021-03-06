﻿using Cis.Model;
using System.Data.Entity.ModelConfiguration;

namespace Cis.Data
{
    public class SalesOrderConfig: EntityTypeConfiguration<SalesOrder>
    {
        public SalesOrderConfig()
        {
            Property(e => e.SalesNo)
                .HasMaxLength(12)
                .IsRequired();

            Property(e => e.CustomerId)
                .HasMaxLength(36)
                .IsRequired();

            Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.CustomerAddress)
                .IsRequired();

            Property(e => e.CustomerProvinceId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.CustomerDistrictId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.CustomerPostalCode)
                .HasMaxLength(5)
                .IsOptional();

            Property(e => e.CustomerPhone)
                .IsOptional();

            Property(e => e.CustomerEmail)
                .IsOptional();

            Property(e => e.CustomerNpwp)
                .IsOptional();

            Property(e => e.DeliveryAddress)
                .IsRequired();

            Property(e => e.DeliveryProvinceId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.DeliveryDistrictId)
                .HasMaxLength(10)
                .IsRequired();

            Property(e => e.DeliveryPostalCode)
                .HasMaxLength(5)
                .IsOptional();

            Property(e => e.SalesmanId)
                 .HasMaxLength(36)
                 .IsRequired();

            Property(e => e.SalesmanCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.SalesAreaId)
                 .HasMaxLength(36)
                 .IsRequired();

            Property(e => e.SalesAreaCode)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.SalesDate)
                .IsRequired();

            Property(e => e.TermOfPaymentId)
               .HasMaxLength(36)
               .IsRequired();

            Property(e => e.TermOfPaymentCode)
               .HasMaxLength(50)
               .IsRequired();

            Property(e => e.DueDate)
                .IsRequired();

            Property(e => e.PersonInCharge)
                .IsRequired();

            Property(e => e.SipaNo)
                .IsRequired();

            Property(e => e.SubTotalAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.ExtraDiscountAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.TaxBaseAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.ValueAddedTaxAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.GrandTotalAmount)
                .HasPrecision(15, 5)
                .IsRequired();

            Property(e => e.UserId)
               .HasMaxLength(36)
               .IsRequired();

            Property(e => e.Username)
               .HasMaxLength(50)
               .IsRequired();

            Property(e => e.Status)
                .IsRequired();


            HasIndex(e => e.SalesNo)
               .IsUnique();
        }
    }
}
