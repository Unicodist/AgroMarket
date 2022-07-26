using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
