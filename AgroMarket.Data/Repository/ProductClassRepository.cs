using AgroMarket.Data.Models;
using AgroMarket.Shared.Exception;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket.Data.Repository;

public class ProductClassRepository : BaseRepository<ProductClass>
{
    public ProductClassRepository(AmContext context) : base(context)
    {
    }
    
    public async Task<ProductClass> GetByName(string categoryName)
    {
        return await GetQueryable().SingleOrDefaultAsync(x => x.Name.Equals(categoryName))??throw new ProductClassNotFoundException();
    }
}