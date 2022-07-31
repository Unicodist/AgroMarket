using AgroMarket.Data.Converters;
using AgroMarket.Data.Models;
using AgroMarket.Shared.Enum;
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
        _ = builder.Property(a => a.PanNumber).HasColumnName("user_pannumber");
        _ = builder.Property(a => a.MobileNumber).HasColumnName("mobile_number");
        _ = builder.Property(a => a.Password).HasColumnName("password");
        _ = builder.Property(a => a.Address).HasColumnName("user_address");
    }
}