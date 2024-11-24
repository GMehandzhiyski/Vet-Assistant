using VetAssistant.Data.Extensions;

namespace VetAssistant.Web
{
    public class Program
    {
        public static void Main(string[] args)
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Authentication and Authorization middleware
            app.UseAuthentication();
            app.UseAuthorization();

            //Seed Admin User
            var adminSettings = builder.Configuration.GetSection("AdminSettings");

            string email = adminSettings["Email"];
            string username = adminSettings["Username"];
            string password = adminSettings["Password"];

            app.SeedAdministrator(email, username, password);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Add routing to Identity Razor Pages
            app.MapRazorPages();

            app.Run();
        }
    }
}