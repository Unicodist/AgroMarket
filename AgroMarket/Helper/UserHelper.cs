using System.Security.Claims;
using AgroMarket.Data.Models;
using AgroMarket.Data.Repository;
using AgroMarket.Shared.Enum;
using Microsoft.AspNetCore.Mvc;

namespace AgroMarket.Helper;

public class UserHelper
{
    private readonly UserRepository _userRepository;

    public UserHelper(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public User GetCurrentUser(Controller context)
    {
        var mobilePhone = context.User.Claims.SingleOrDefault(x => x.Type == ClaimTypes.MobilePhone).Value;
        return _userRepository.GetByMobileNumber(mobilePhone);
    }

    public UserType GetRole(string mobile)
    {
        return _userRepository.GetByMobileNumber(mobile).Type;
    }
}