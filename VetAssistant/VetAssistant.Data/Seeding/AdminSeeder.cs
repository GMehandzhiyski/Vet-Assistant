using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetAssistant.Data.Models;
using static VetAssistant.Common.DateConstants;

namespace VetAssistant.Data.Seeding
{
    public class AdminSeeder : ISeeder
    {
        private readonly IConfiguration configuration;

        public AdminSeeder(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public async Task SeedAsync(VetAssistantDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            await GenerateAdminProfileAsync(userManager, roleManager, AdminRoleName);
        }

        private async Task GenerateAdminProfileAsync(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, string roleName)
        {
            var adminSettings = configuration.GetSection("AdminSettings");

            string email = adminSettings["Email"];
            string username = adminSettings["Username"];
            string password = adminSettings["Password"];

            var admin = await userManager.FindByNameAsync(email);

            if (admin == null)
            {
                ApplicationUser adminUser = new ApplicationUser
                {
                    UserName = username,
                    Email = email,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    CreatedOn = DateTime.UtcNow
                };

                var registerResult = await userManager.CreateAsync(adminUser, password);
                if (!registerResult.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, registerResult.Errors.Select(e => e.Description)));
                }

                var roleResult = await userManager.AddToRoleAsync(adminUser, roleName);

                if (!roleResult.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, roleResult.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
