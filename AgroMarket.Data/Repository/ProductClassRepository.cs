using AgroMarket.Data.Models;

namespace AgroMarket.Data.Repository;

public class ProductClassRepository : BaseRepository<ProductClass>
{
    public ProductClassRepository(AmContext context) : base(context)
    {
    }
}