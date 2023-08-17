using AmazingGeekShop.Domain.Entities;
using AmazingGeekShop.Domain.Interfaces.Common;
using AmazingGeekShop.Infrastructure.Context;
using AmazingGeekShop.Infrastructure.Repositories;
using AmazingGeekShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AmazingGeekShop.Infrastructure.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(configuration["CONNECTION"]
            , new MySqlServerVersion(new Version(8,1,0))));

        services.AddScoped<IProductRepository, ProductRepository>();
        return services;

    }
}