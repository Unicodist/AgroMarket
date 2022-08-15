using AgroMarket.Data.Models;
using AgroMarket.Shared.Exception;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket.Data.Repository;

public class ProductRepository : BaseRepository<Product>
{
    public ProductRepository(AmContext context) : base(context)
    {
    }
}