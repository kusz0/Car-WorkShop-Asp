using CarWorkShop.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkShop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtencions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Persistance.CarWorkShopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CarWorkShop")));

            services.AddScoped<CarWorkShopSeeder>();
            
        }
    }
}
