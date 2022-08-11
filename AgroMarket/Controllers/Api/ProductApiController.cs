using AgroMarket.Helper;
using AgroMarket.Service.Dto.Product;
using AgroMarket.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api;

public class ProductApiController : ApiControllerBase
{
    [HttpPost]
    public IActionResult Create(ProductCreateViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Please fill the form carefully");
        }

        var dto = new ProductCreateDto()
        {
            Name = model.Name,
            CategoryId = model.CategoryId,
            Stock = model.Stock,
            Date = model.ExpiryDate,
            Picture = ProductFileHelper.UploadFile(model.Picture),
            Description = model.Description,
        };
        return Ok();
    }
}