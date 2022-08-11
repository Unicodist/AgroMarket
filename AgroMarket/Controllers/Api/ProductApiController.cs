using AgroMarket.Service.Dto.Product;
using AgroMarket.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api;

public class ProductApiController : ApiControllerBase
{
    public IActionResult Create(ProductCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Please fill the form carefully");
        }
        var dto = new ProductCreateDto()
        {
            
        }
    }
}