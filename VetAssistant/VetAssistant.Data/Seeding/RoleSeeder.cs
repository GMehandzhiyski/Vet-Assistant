using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using VetAssistant.Data.Models;
using static VetAssistant.Common.DateConstants;

namespace VetAssistant.Data.Seeding
{
    public class RoleSeeder
    {
        public async Task SeedAsync(VetAssistantDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

            await SeedRoleAsync(roleManager, AdminRoleName);
        }

        private static async Task SeedRoleAsync(RoleManager<ApplicationRole> roleManager, string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new ApplicationRole(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
