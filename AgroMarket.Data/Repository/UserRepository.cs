using AgroMarket.Data.Models;
using AgroMarket.Shared.Exception;

namespace AgroMarket.Data.Repository;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(AmContext context) : base(context)
    {
    }

    public User GetByUsername(string mobileNumber)
    {
        return GetQueryable().SingleOrDefault(x => x.MobileNumber == mobileNumber)??throw new UserNotFoundException();
    }
}