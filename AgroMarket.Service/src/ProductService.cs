
using AgroMarket.Data.Models;
using AgroMarket.Data.Repository;
using AgroMarket.Service.Dto.Product;
using AgroMarket.Service.src.Dto.User;
using AgroMarket.Shared.Exception;

namespace AgroMarket.Service;

public class ProductService
{
    private readonly ProductRepository _productRepo;
    private readonly ProductClassRepository _productClassRepo;
    private readonly UserRepository _userRepository;

    public ProductService(ProductRepository productRepo, ProductClassRepository productClassRepo, UserRepository userRepository)
    {
        _productRepo = productRepo;
        _productClassRepo = productClassRepo;
        _userRepository = userRepository;
    }

    public async Task Insert(ProductCreateDto dto)
    {
        _ = _productRepo.GetQueryable().SingleOrDefault(x => x.Name == dto.Name);

        var category = await _productClassRepo.GetByIdAsync(dto.CategoryId) ??
                       throw new ProductClassNotFoundException();
        var farmer = _userRepository.GetByMobileNumber(dto.FarmerMobileNumber)??throw new FarmerNotFoundException();
        var product = new Product(dto.Name,dto.Description,dto.Picture,dto.Date,dto.Price,dto.Stock,category,farmer);
        await _productRepo.InsertAsync(product);
        
    }

    public async Task Update(ProductUpdateDto dto)
    {
        var product = await _productRepo.GetByIdAsync(dto.Id)?? throw new ProductNotFoundException();
        var productClass = product.Class;
        if (dto.CategoryId!=product.ProductClassId)
        {
            productClass = await _productClassRepo.GetByIdAsync(dto.CategoryId) ?? throw new ProductClassNotFoundException();
        }

        product.Update(dto.Name, dto.Description, dto.Date, dto.Picture, dto.Price, dto.Stock, productClass);
        await _productRepo.UpdateAsync(product);
    }
    public async Task Delete(long id)
    {
        var product = await _productRepo.GetByIdAsync(id)??throw new ProductNotFoundException();
        _productRepo.Delete(product);
    }
}