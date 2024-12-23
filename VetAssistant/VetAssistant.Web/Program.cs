using VetAssistant.Data;
using VetAssistant.Data.Repository;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Data.Seeding;
using VetAssistant.Service.Data;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddApplicationDatabase(builder.Configuration);

            //To add in appsettings.json
            // string adminEmail = builder.Configuration.GetValue<string>("Administrator:Email")!;
            //string adminUsername = builder.Configuration.GetValue<string>("Administrator:Username")!;
            // string adminPassword = builder.Configuration.GetValue<string>("Administrator:Password")!;

            // Add services to the container.
            // I Add this to extension method
            //var connectionString = builder.Configuration
            //    .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            //builder.Services.AddDbContext<VetAssistantDbContext>(options =>
            //    options.UseSqlServer(connectionString));

            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();


            ///old to be deleted soon
            ////////////////////////////////////////////////////////////////////////////////

            //builder.Services
            //    .AddDefaultIdentity<IdentityUser>(options =>
            //        options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<VetAssistantDbContext>();

            // Change Default Identity User with new Application User
            //builder.Services
            //  .AddDefaultIdentity<ApplicationUser>(options =>
            //      options.SignIn.RequireConfirmedAccount = true)
            //  .AddEntityFrameworkStores<VetAssistantDbContext>();

            //Identity Service -with this is work 23.11.24, I replace this with Custom Identity Behavior
            //builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = false;
            //    options.Password.RequireDigit = false;
            //    options.Password.RequireNonAlphanumeric = false;
            //    options.Password.RequireUppercase = false;
            //})
            //    .AddRoles<IdentityRole<Guid>>()
            //    .AddEntityFrameworkStores<VetAssistantDbContext>();
            ////////////////////////////////////////////////////////////////////////////////////

            //Add custom Identity Behavior
            builder.Services.AddApplicationIdentity(builder.Configuration);
            // I Add this to extension method
            //builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            //   .AddEntityFrameworkStores<VetAssistantDbContext>()
            //   .AddDefaultTokenProviders();


            //Add All Repository
            builder.Services.AddApplicationServices(builder.Configuration);
            // I Add this to extension method
            //builder.Services.AddScoped<IRepository<Booking, Guid>, IRepository<Booking, Guid>>();
            //builder.Services.AddScoped<IRepository<IClinicService, Guid>, Repository<ClinicService< Guid>>();
            builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            builder.Services.AddScoped<IClinicService, ClinicService>();




            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //Seed data on application startup

            //Seed roles and admin user on application startup
            using (var serviceScope = app.Services.CreateScope())
            {
                var serviceProvider = serviceScope.ServiceProvider;
                var dbContext = serviceProvider.GetRequiredService<VetAssistantDbContext>();

                // Seed roles
                var roleSeeder = new RoleSeeder();
                await roleSeeder.SeedAsync(dbContext, serviceProvider);

                // Seed admin
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                var adminSeeder = new AdminSeeder(configuration);
                await adminSeeder.SeedAsync(dbContext, serviceProvider);


            }
            //using (var scope = app.Services.CreateScope())
            //{
            //    var roleManager =
            //        scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            //    var roles = new[] { "Admin", "Manager", "Member" };

            //    foreach (var role in roles)
            //    {
            //        if (await roleManager.RoleExistsAsync(role)
            //           await roleManager.CreateAsync(new ApplicationRole(role));
            //    }
            //}


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Authentication and Authorization middleware
            app.UseAuthentication();
            app.UseAuthorization();

            //Seed Admin User
            //var adminSettings = builder.Configuration.GetSection("AdminSettings");

            //string email = adminSettings["Email"];
            //string username = adminSettings["Username"];
            //string password = adminSettings["Password"];

            //app.SeedAdministrator(email, username, password);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Add routing to Identity Razor Pages
            app.MapRazorPages();

            app.Run();
        }
    }
}