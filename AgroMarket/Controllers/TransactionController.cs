using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
