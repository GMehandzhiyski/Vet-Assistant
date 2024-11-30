using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VetAssistant.Data;
using VetAssistant.Data.Models;



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

            services.AddDefaultIdentity<ApplicationUser>()
                    .AddRoles<ApplicationRole>()
                    .AddEntityFrameworkStores<VetAssistantDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            });

            services.ConfigureApplicationCookie(option =>
            {
                option.LogoutPath = "/Identity/Account/Login";
                //Add more.....
            });



            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IRepository<Booking, Guid>, Repository<Booking, Guid>>();
            //services.AddScoped<IClinicService, ClinicService>(); ->  Is not working is need to be fixed




            return services;
        }


    }
}

