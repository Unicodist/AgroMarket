using AgroMarket.Data.Repository;

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

        _userRepo.InsertAsync(dto);
    }
}