using AgroMarket.Data.Converters;
using AgroMarket.Data.Models;
using AgroMarket.Shared.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgroMarket.Data.Mapping
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            _ = builder.ToTable("transaction");
            _ = builder.HasKey(a => a.Id);
            _ = builder.Property(a => a.Id).HasColumnName("transaction_id");
            _ = builder.Property(a => a.State).HasColumnName("transaction_state").HasConversion(new EnumConverter<ShipmentState>());

            _ = builder.Property(a => a.OrderId).HasColumnName("order_id");

            _ = builder.HasOne(a => a.Order).WithMany().HasForeignKey(a => a.OrderId);

        }
    }
}
