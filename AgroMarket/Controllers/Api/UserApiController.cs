using AgroMarket.Service;
using AgroMarket.Service.Dto.User;
using AgroMarket.ViewModel;
using AgroMarket.ViewModel.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AgroMarket.Controllers.Api;
[Route("api/user")]
public class UserApiController : ApiControllerBase
{
    private readonly UserService _userService;

    // GET
    public UserApiController(UserService userService)
    {
        _userService = userService;
    }
    [AllowAnonymous]
    [Route("login")]
    public async Task<IActionResult> Login(UserLoginViewModel model)
    {
        var user = _userService.Login(model.MobileNumber, model.Password);
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.MobilePhone,user.MobileNumber),
            new Claim(ClaimTypes.Role,user.Type.ToString()),
            new Claim(ClaimTypes.Name,user.Name),
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity));
        return Ok();
    }

    [AllowAnonymous]
    [Route("signup")]
    public async Task<IActionResult> Signup([FromForm] UserCreateViewModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var userCreateDto = new UserCreateDto(model.Name,model.MobileNumber,model.Password,model.Address);
        await _userService.Insert(userCreateDto);
        return Ok();
    }
}