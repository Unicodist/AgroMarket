using AgroMarket.Data.Repository;
using AgroMarket.Helper;
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
            var carts=_cartRepository.GetQueryable().Where(x => x.UserId == user.Id).ToList();
            return Ok(carts);
        }
    }
}
