using AgroMarket.Helper;
using AgroMarket.Service.Dto.Product;
using AgroMarket.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api;

public class ProductApiController : ApiControllerBase
{
    private readonly ProductFileHelper _productHelper;

    public ProductApiController(ProductFileHelper productHelper)
    {
        _productHelper = productHelper;
    }

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
            CategoryId = model.CategoryId??1,
            Stock = model.Stock,
            Date = model.ExpiryDate,
            Picture = _productHelper.UploadFile(model.Picture),
            Description = model.Description,
        };
        return Ok();
    }
}