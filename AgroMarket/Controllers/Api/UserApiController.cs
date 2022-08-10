﻿using AgroMarket.Data.Repository;
using AgroMarket.Service;
using AgroMarket.Service.Dto.User;
using AgroMarket.Shared.Exception;
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
    private readonly UserRepository _userRepo;

    // GET
    public UserApiController(UserService userService, UserRepository userRepo)
    {
        _userService = userService;
        _userRepo = userRepo;
    }
    [AllowAnonymous]
    [Route("login")]
    public async Task<IActionResult> Login([FromForm]UserLoginViewModel model)
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
        if (model.ReturnUrl==null)
        {
            model.ReturnUrl = "/Home";
        }
        return Ok(new{Url=model.ReturnUrl});
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

    public async Task<JsonResult> Get(int id)
    {
        var user = await _userRepo.GetByIdAsync(id)??throw new UserNotFoundException();
        var userModel = new UserViewModel
        {
            Id = user.Id,
            Name = user.Name,
            Address = user.Address,
            PanNo = user.PanNumber,
        };
        return new JsonResult(userModel);
    }
}