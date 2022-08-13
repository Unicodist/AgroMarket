using AgroMarket.Data.Models;

namespace AgroMarket.Data.Repository;

public class OrderProductRepository : BaseRepository<OrderProduct>
{
    public OrderProductRepository(AmContext context) : base(context)
    {
    }
}