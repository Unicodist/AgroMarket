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
        var user = new User(dto.Name,dto.MobileNumber,BCrypt.Net.BCrypt.HashPassword(dto.Password), dto.Address);
        await _userRepo.InsertAsync(user);
    }

    public User Login(string mobileNumber, string password)
    {
        var user = _userRepo.GetByMobileNumber(mobileNumber);
        if(BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return user;
        }
        throw new Exception("Wrong password");
    }
    public async Task Update(UserUpdateDto dto)
    {
        var user = 
       
        await _userRepo.UpdateAsync(user);
    }
}