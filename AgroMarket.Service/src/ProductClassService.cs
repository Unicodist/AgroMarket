using AgroMarket.Data.Models;
using AgroMarket.Data.Repository;
using AgroMarket.Service.src.Dto.User;
using AgroMarket.Shared.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Service
{
    public class ProductClassService
    {
        private readonly ProductClassRepository _productclassRepo;

        public ProductClassService(ProductClassRepository productclassRepo)
        {
            _productclassRepo = productclassRepo;
        }

        public async Task Insert(string name)
        {
            var category = _productclassRepo.GetQueryable().First(x => x.Name == name);
            if (category != null) throw new ProductClassAlreadyExistException();
            var productClass = new ProductClass(name);
            await _productclassRepo.InsertAsync(productClass);
        }

        public async Task Update(ProductClassUpdateDto dto)
        {
            var category = await _productclassRepo.GetByIdAsync(dto.Id)?? throw new ProductClassNotFoundException();
            await _productclassRepo.UpdateAsync(category);
        }
        public async Task Delete(long id)
        {
            var category = await _productclassRepo.GetByIdAsync(id)??throw new ProductClassNotFoundException();
            _productclassRepo.Delete(category);
        }


    }
}
