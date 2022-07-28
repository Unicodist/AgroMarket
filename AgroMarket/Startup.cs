using AgroMarket.Data;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket;

public static class Startup
{
    public static void ConfigureStartup(this IServiceCollection service)
    {
        service.AddDbContext<AmContext>(a => a.UseLazyLoadingProxies());
    }
}