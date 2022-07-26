using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
