//using Microsoft.Extensions.Configuration;

//namespace Microsoft.Extensions.DependencyInjection
//{

//    public static class IDServiceCollectionExtension
//    {
//        public static IServiceCollection AddAplicationDatabase(this IServiceCollection services, IConfiguration configuration)
//        {

//            var connectionString = configuration
//               .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

//            services.AddDbContext<VetAssistantDbContext>(options =>
//                options.UseSqlServer(connectionString));

//            services.AddDatabaseDeveloperPageExceptionFilter();

//            return services;
//        }

//        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration configuration)
//        {

//            return services;
//        }

//        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
//        {

//            return services;
//        }


//    }
//}


