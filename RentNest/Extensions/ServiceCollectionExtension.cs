using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RentNest.Core.Contracts.House;
using RentNest.Core.Services;
using RentNest.Infrastructure.Data;
using RentNest.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection //When extend service collection is good to be in this namespace
{
    //When the class is Extensions, have to be static
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IHouseService, HouseService>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<RentNestDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();

            services.AddDatabaseDeveloperPageExceptionFilter();


            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;  
                })
                .AddEntityFrameworkStores<RentNestDbContext>();

            return services;
        }
    }
}
