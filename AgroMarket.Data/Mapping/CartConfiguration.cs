using AgroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.Mapping
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            _ = builder.ToTable("cart");
            _ = builder.HasKey(a => a.Id);
            _ = builder.Property(a => a.Id).HasColumnName("cart_id");
            _ = builder.Property(a => a.UserId).HasColumnName("user_id");
            _ = builder.Property(a => a.ProductId).HasColumnName("product_id");

            _ = builder.HasOne(a => a.AddedBy).WithMany().HasForeignKey(a => a.UserId);
            _ = builder.HasOne(a => a.Product).WithMany().HasForeignKey(a => a.ProductId);

        }
    }
}
