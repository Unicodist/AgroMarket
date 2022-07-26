using AgroMarket.Data.Converters;
using AgroMarket.Data.Enum;
using AgroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroMarket.Data.Mapping;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        _ = builder.ToTable("user");
        _ = builder.HasKey(a => a.Id);
        _ = builder.Property(a => a.Id).HasColumnName("user_id");
        _ = builder.Property(a => a.Type).HasColumnName("user_type").HasConversion(new EnumConverter<UserType>());
    }
}