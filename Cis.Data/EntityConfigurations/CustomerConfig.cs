using Cis.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data
{
    public class CustomerConfig: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("CUSTOMER");

            builder.Property(c => c.Name)
                .HasColumnName("NAME")
                .IsRequired();

            builder.Property(c => c.Address)
                .HasColumnName("ADDRESS")
                .IsRequired();

            builder.Property(c => c.LocationId)
                .HasColumnName("LOC_ID")
                .IsRequired();

            builder.Property(c => c.PostalCode)
                .HasColumnName("POSTAL_CD")
                .IsRequired(false);

            builder.Property(c => c.Phone)
                .HasColumnName("PHONE")
                .IsRequired(false);

            builder.Property(c => c.Email)
                .HasColumnName("EMAIL")
                .IsRequired(false);

            builder.Property(c => c.Npwp)
                .HasColumnName("NPWP")
                .IsRequired(false);

            builder.Property(c => c.PharmacistName)
                .HasColumnName("PHARMACIST_NAME")
                .IsRequired(false);

            builder.Property(c => c.SipaNo)
                .HasColumnName("SIPA_NO")
                .IsRequired(false);

            builder.Property(c => c.SipaExpiredDate)
                .HasColumnName("SIPA_EXP_DATE")
                .IsRequired();

            builder.Property(c => c.SiaNo)
                .HasColumnName("SIA_NO")
                .IsRequired(false);

            builder.Property(c => c.OutletTypeId)
                .HasColumnName("OUTLET_TYPE_ID")
                .IsRequired();

            builder.Property(c => c.SalesAreaId)
                .HasColumnName("SALES_AREA_ID")
                .IsRequired();

            new BaseEntityConfig<Customer>().Configure(ref builder);


            builder
                .HasIndex(c => c.Name)
                .HasName("IX_CUST_NAME");

            builder.HasOne(c => c.Location)
                .WithMany(l => l.Customers)
                .HasForeignKey(c => c.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.SalesArea)
                .WithMany(s => s.Customers)
                .HasForeignKey(c => c.SalesAreaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.OutletType)
                .WithMany(o => o.Customers)
                .HasForeignKey(c => c.OutletTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
