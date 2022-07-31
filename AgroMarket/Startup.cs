using AgroMarket.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace AgroMarket;

public static class Startup
{
    public static void ConfigureStartup(this IServiceCollection service)
    {
        service.AddDbContext<AmContext>(a => a.UseLazyLoadingProxies());

        service.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie();

        service.AddAuthorization(options =>
        {
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
        });
    }
}