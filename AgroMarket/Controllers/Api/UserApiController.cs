using AgroMarket.Service;
using AgroMarket.Service.Dto.User;
using AgroMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Controllers.Api;

public class UserApiController : ControllerBase
{
    private readonly UserService _userService;

    // GET
    public UserApiController(UserService userService)
    {
        _userService = userService;
    }

    public IActionResult Login(UserCreateViewModel model)
    {
        if (!ModelState.IsValid)
            throw new Exception("The format is not right");

        var userCreateDto = new UserCreateDto(model.Name,model.MobileNumber);
        _userService.Insert(userCreateDto);
        return Ok();
    }
}