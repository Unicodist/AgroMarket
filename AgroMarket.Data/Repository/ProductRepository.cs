using AgroMarket.Data.Models;

namespace AgroMarket.Data.Repository;

public class ProductRepository : BaseRepository<Product>
{
    public ProductRepository(AmContext context) : base(context)
    {
    }
}