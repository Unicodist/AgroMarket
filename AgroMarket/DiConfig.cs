using AgroMarket.Data;
using AgroMarket.Data.Repository;
using AgroMarket.Service;

namespace AgroMarket;

public static class DiConfig
{
    public static void DiConf(this IServiceCollection service)
    {
        service.AddSingleton<AmContext>();

        service.AddSingleton<UserService>();

        service.AddSingleton<UserRepository>();
    }
}