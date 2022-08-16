using AgroMarket.Data.Models;
using AgroMarket.Data.Repository;
using AgroMarket.Service.src.Dto.Cart;
using AgroMarket.Shared.Exception;

namespace AgroMarket.Service;

public class CartService
{
    private readonly CartRepository _cartRepo;
    private readonly ProductRepository _productRepo;
    private readonly UserRepository _userRepository;

    public CartService(CartRepository cartRepo, ProductRepository productRepo, UserRepository userRepository)
    {
        _cartRepo = cartRepo;
        _productRepo = productRepo;
        _userRepository = userRepository;
    }
    public async Task Insert(CartCreateDto dto)
    {

        var user = await _userRepository.GetByIdAsync(dto.UserId) ??
                       throw new UserNotFoundException();
        var product = await _productRepo.GetByIdAsync(dto.ProductId) ?? throw new ProductNotFoundException();
        var cart = new Cart(user, product);
        await _cartRepo.InsertAsync(cart);

    }

}