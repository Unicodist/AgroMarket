using System.Security.Claims;
using AgroMarket.Helper;
using AgroMarket.Service;
using AgroMarket.Service.Dto.Product;
using AgroMarket.ViewModel.Product;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api;

public class ProductApiController : ApiControllerBase
{
    private readonly ProductFileHelper _productHelper;
    private readonly ProductService _productService;

    public ProductApiController(ProductFileHelper productHelper, ProductService productService)
    {
        _productHelper = productHelper;
        _productService = productService;
    }

    public async Task<IActionResult> Create([FromForm]ProductCreateViewModel model)
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
            Picture = await _productHelper.UploadFile(model.Picture),
            Description = model.Description,
            Price = model.Price,
            FarmerMobileNumber = User.Claims.Single(x=>x.Type.Equals(ClaimTypes.MobilePhone)).Value,
        };
        await _productService.Insert(dto);
        return Ok();
    }
}