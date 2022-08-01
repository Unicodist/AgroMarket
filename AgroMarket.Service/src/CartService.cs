using AgroMarket.Data.Repository;

namespace AgroMarket.Service;

public class CartService
{
    private readonly CartRepository _cartRepo;

    public CartService(CartRepository cartRepo)
    {
        _cartRepo = cartRepo;
    }

   
}