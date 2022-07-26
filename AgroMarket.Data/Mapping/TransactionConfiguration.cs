using AgroMarket.Data.Models;
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
            
        }
    }
}
