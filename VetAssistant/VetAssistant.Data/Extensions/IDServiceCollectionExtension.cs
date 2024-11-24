using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VetAssistant.Data;
using VetAssistant.Data.Models;
using VetAssistant.Data.Repository;
using VetAssistant.Data.Repository.Interfaces;

namespace Microsoft.Extensions.DependencyInjection
{

    public static class IDServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration
               .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            services.AddDbContext<VetAssistantDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            //with this is work good
            //services.AddDefaultIdentity<UserDetails>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = false;
            //    options.Password.RequireDigit = false;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //})
            //    .AddRoles<IdentityRole<Guid>>()
            //    .AddEntityFrameworkStores<VetAssistantDbContext>();

            //still not work
            // is need Migration and Update Date base??????
            services.AddIdentity<UserDetails, ApplicationRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
               .AddEntityFrameworkStores<VetAssistantDbContext>()
               .AddDefaultTokenProviders()
               .AddDefaultUI();

            services.ConfigureApplicationCookie(option =>
            {
                option.LogoutPath = "/Identity/Account/Login";
                //Add more.....
            });



            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRepository<Booking, Guid>, Repository<Booking, Guid>>();

            return services;
        }


    }
}

