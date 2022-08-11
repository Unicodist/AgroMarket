using AgroMarket.Data.Repository;
using AgroMarket.ViewModel.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductClassRepository _categoryRepo;

        public ProductController(ProductClassRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Recent()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> AddProduct()
        {
            var model = new ProductCreateViewModel()
            {
                Categories =
                    new SelectList((await _categoryRepo.GetQueryable().ToListAsync()).Select(x => new { x.Id, x.Name }),
                        "Id", "Name")
            };
            return View(model);
        }
    }
}
