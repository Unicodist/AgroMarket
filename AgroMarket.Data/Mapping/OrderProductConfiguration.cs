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
            _ = builder.HasNoKey();
            _ = builder.Property(a => a.OrderId).HasColumnName("order_id");
            _ = builder.Property(a => a.ProductId).HasColumnName("product_id");

            _ = builder.HasOne(a => a.Order).WithMany().HasForeignKey(a => a.OrderId);
            _ = builder.HasOne(a => a.Product).WithMany().HasForeignKey(a => a.ProductId);
        }

    }
}
