using AgroMarket.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket.Data;

public class AmContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductClassConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}