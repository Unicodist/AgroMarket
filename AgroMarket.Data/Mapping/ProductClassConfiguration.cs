using AgroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroMarket.Data.Mapping;

public class ProductClassConfiguration : IEntityTypeConfiguration<ProductClass>
{
    private ProductClass _productClass = new()
    {
        Id = 1,
        Name = "Uncategorized",
    };
    public void Configure(EntityTypeBuilder<ProductClass> builder)
    {
        _ = builder.ToTable("product_class");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("product_class_id");
        _ = builder.Property(a => a.Name).HasColumnName("name");

        _ = builder.HasMany(a => a.Products).WithOne(a => a.Class).HasForeignKey(a => a.ProductClassId);
        
        
        builder.HasData(_productClass);
    }
}