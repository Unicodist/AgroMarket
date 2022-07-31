using AgroMarket.Data.Models;

namespace AgroMarket.Data.Repository;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(AmContext context) : base(context)
    {
    }

    public object GetByUsername(string userName)
    {
        throw new NotImplementedException();
    }
}