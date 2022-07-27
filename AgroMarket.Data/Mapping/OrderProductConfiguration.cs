using AgroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroMarket.Data.Mapping
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            _ = builder.ToTable("orderproduct");
            _ = builder.HasKey(a => a.OrderId);
            _ = builder.Property(a => a.OrderId).HasColumnName("orderproduct_orderid");
            _ = builder.Property(a => a.ProductId).HasColumnName("orderproduct_productid");

            _ = builder.HasOne(a => a.Order).WithMany().HasForeignKey(a => a.OrderId);
            _ = builder.HasOne(a => a.Product).WithMany().HasForeignKey(a => a.ProductId);
        }

    }
}
