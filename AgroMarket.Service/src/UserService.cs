using AgroMarket.Data.Models;
using AgroMarket.Data.Repository;
using AgroMarket.Service.Dto.User;

namespace AgroMarket.Service;

public class UserService
{
    private readonly UserRepository _userRepo;

    public UserService(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }

    public async Task Insert(UserCreateDto dto)
    {
        var user = new User(dto.Name,dto.MobileNumber);
        await _userRepo.InsertAsync(user);
    }

    public void Login(string userName, string password)
    {
        throw new NotImplementedException();
    }
}