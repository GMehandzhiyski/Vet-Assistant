using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VetAssistant.Data;
using VetAssistant.Data.Models;

namespace VetAssistant.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration
                .GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<VetAssistantDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //builder.Services
            //    .AddDefaultIdentity<IdentityUser>(options =>
            //        options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<VetAssistantDbContext>();

            // Change Default Identity User with new Application User
            //builder.Services
            //  .AddDefaultIdentity<ApplicationUser>(options =>
            //      options.SignIn.RequireConfirmedAccount = true)
            //  .AddEntityFrameworkStores<VetAssistantDbContext>();

            //Identity Service
            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<VetAssistantDbContext>();

            //builder.Services.AddScoped<IRepository, Repository>();

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Add routing to Identity Razor Pages
            app.MapRazorPages();

            app.Run();
        }
    }
}