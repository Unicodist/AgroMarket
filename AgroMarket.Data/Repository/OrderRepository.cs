using AgroMarket.Data.Models;

namespace AgroMarket.Data.Repository;

public class OrderRepository : BaseRepository<Order>
{
    public OrderRepository(AmContext context) : base(context)
    {
    }
}