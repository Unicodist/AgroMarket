using AgroMarket.Data.Repository;
using AgroMarket.Helper;
using AgroMarket.Service;
using AgroMarket.Service.src.Dto.Cart;
using AgroMarket.ViewModel.Cart;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api
{
    public class CartApiController : ApiControllerBase
    {
        private readonly UserHelper _userHelper;
        private readonly CartRepository _cartRepository;
        private readonly CartService _cartService;

        public CartApiController(UserHelper userHelper, CartRepository cartRepository, CartService cartService)
        {
            _userHelper = userHelper;
            _cartRepository = cartRepository;
            _cartService = cartService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = _userHelper.GetCurrentUser(this);
            var carts=_cartRepository.GetQueryable().Where(x => x.UserId == user.Id);
            var model = carts.Select(x => new CartReponseApiModel()
            {
                Name = x.Product.Name,
                Id = x.Id,
                Price = x.Product.Price,
                Stock = x.Product.Stock,
            }).ToList();
            return Ok(model);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(long productId)
        {
            var user = _userHelper.GetCurrentUser(this);
            var dto = new CartCreateDto()
            {
                UserId = user.Id,
                ProductId = productId,
            };
            await _cartService.Insert(dto);
            return Ok();
        }
    }
}
