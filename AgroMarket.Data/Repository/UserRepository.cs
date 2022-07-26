using AgroMarket.Data.Models;

namespace AgroMarket.Data.Repository;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(AmContext context) : base(context)
    {
    }
}