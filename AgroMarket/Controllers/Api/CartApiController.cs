using AgroMarket.Data.Repository;
using AgroMarket.Helper;
using AgroMarket.ViewModel.Cart;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api
{
    public class CartApiController : ApiControllerBase
    {
        private readonly UserHelper _userHelper;
        private readonly CartRepository _cartRepository;

        public CartApiController(UserHelper userHelper, CartRepository cartRepository)
        {
            _userHelper = userHelper;
            _cartRepository = cartRepository;
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
    }
}
