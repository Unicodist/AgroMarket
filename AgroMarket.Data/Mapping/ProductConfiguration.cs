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
        _ = builder.Property(a => a.ProductClassId).HasColumnName("product_id");

        _ = builder.HasOne(a => a.Class).WithMany(a => a.Products).HasForeignKey(a=>a.ProductClassId);
    }
}