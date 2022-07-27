using AgroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroMarket.Data.Mapping;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        _ = builder.ToTable("product");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("product_id");

        _ = builder.Property(a => a.ProductClassId).HasColumnName("productclass_id");

        _ = builder.HasOne(a => a.Class).WithMany(a => a.Products).HasForeignKey(a=>a.ProductClassId);

        _ = builder.Property(a => a.Name).HasColumnName("product_name");
        _ = builder.Property(a => a.Description).HasColumnName("product_description");
        _ = builder.Property(a => a.ExpiryDate).HasColumnName("product_expirydate");
        _ = builder.Property(a => a.Price).HasColumnName("product_price");
        _ = builder.Property(a => a.Stock).HasColumnName("product_stock");

        _ = builder.Property(a => a.FarmerId).HasColumnName("farmer_id");

        _ = builder.HasOne(a => a.Farmer).WithMany().HasForeignKey(a => a.FarmerId);
    }
}