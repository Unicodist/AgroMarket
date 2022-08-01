using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
