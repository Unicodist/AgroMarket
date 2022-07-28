using AgroMarket.Data.Models;
using AgroMarket.Data.Repository;
using AgroMarket.Service.src.Dto.User;

namespace AgroMarket.Service;

public class UserService
{
    private readonly UserRepository _userRepo;

    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    public Task Insert(UserCreateDto dto)
    {
        var user = new User(dto.Name,dto.MobileNumber);
        _userRepo.InsertAsync(user);
        return Task.CompletedTask;
    }
}