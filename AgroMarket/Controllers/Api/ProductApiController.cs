﻿using System.Security.Claims;
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
    private readonly ProductClassService _productClassService;

    public ProductApiController(ProductFileHelper productHelper, ProductService productService, ProductClassService productClassService)
    {
        _productHelper = productHelper;
        _productService = productService;
        _productClassService = productClassService;
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
    
    [Route("addCategory")]
    [HttpPost]
    public async Task<IActionResult> AddCategory([FromForm]string categoryName)
    {
        await _productClassService.Insert(categoryName);
        return Ok();
    }
}