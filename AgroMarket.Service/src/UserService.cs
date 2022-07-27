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

        //_userRepo.InsertAsync(dto);
        return Task.CompletedTask;
    }
}