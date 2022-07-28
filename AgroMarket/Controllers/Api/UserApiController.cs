using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api;

public class UserApiController : ControllerBase
{
    // GET
    public IActionResult Index()
    {
        return Ok();
    }
}