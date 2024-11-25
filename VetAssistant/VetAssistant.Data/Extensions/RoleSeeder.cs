using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using VetAssistant.Data.Models;
using static VetAssistant.Common.DateConstants;

namespace VetAssistant.Data.Extensions
{
    public static class RoleSeeder
    {
        public static async Task<IApplicationBuilder> SeedAdministrator(this IApplicationBuilder app, string email, string username, string password)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateAsyncScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            RoleManager<ApplicationRole>? roleManager = serviceProvider
                .GetService<RoleManager<ApplicationRole>>();
            IUserStore<UserDetails>? userStore = serviceProvider
                .GetService<IUserStore<UserDetails>>();
            UserManager<UserDetails>? userManager = serviceProvider
                .GetService<UserManager<UserDetails>>();

            if (roleManager == null)
            {
                throw new ArgumentNullException(nameof(roleManager),
                    $"Service for {typeof(RoleManager<ApplicationRole>)} cannot be obtained!");
            }

            if (userStore == null)
            {
                throw new ArgumentNullException(nameof(userStore),
                    $"Service for {typeof(IUserStore<UserDetails>)} cannot be obtained!");
            }

            if (userManager == null)
            {
                throw new ArgumentNullException(nameof(userManager),
                    $"Service for {typeof(UserManager<UserDetails>)} cannot be obtained!");
            }


            bool roleExists = await roleManager.RoleExistsAsync(AdminRoleName);
            ApplicationRole? adminRole = null;
            if (!roleExists)
            {
                adminRole = new ApplicationRole(AdminRoleName);

                IdentityResult result = await roleManager.CreateAsync(adminRole);
                if (!result.Succeeded)
                {
                    throw new InvalidOperationException($"Error occurred while creating the {AdminRoleName} role!");
                }
            }
            else
            {
                adminRole = await roleManager.FindByNameAsync(AdminRoleName);
            }

            UserDetails? adminUser = await userManager.FindByEmailAsync(email);
            if (adminUser == null)
            {
                adminUser = await
                    CreateAdminUserAsync(email, username, password, userStore, userManager);
            }

            if (await userManager.IsInRoleAsync(adminUser, AdminRoleName))
            {
                return app;
            }

            IdentityResult userResult = await userManager.AddToRoleAsync(adminUser, AdminRoleName);
            if (!userResult.Succeeded)
            {
                throw new InvalidOperationException($"Error occurred while adding the user {username} to the {AdminRoleName} role!");
            }

            return app;
        }

        private static async Task<UserDetails> CreateAdminUserAsync(string email, string username, string password,
            IUserStore<UserDetails> userStore, UserManager<UserDetails> userManager)
        {
            UserDetails applicationUser = new UserDetails
            {
                Email = email
            };

            await userStore.SetUserNameAsync(applicationUser, username, CancellationToken.None);
            IdentityResult result = await userManager.CreateAsync(applicationUser, password);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Error occurred while registering {AdminRoleName} user!");
            }

            return applicationUser;
        }



    }
}
