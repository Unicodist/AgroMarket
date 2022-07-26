using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers
{
    public class FarmerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
