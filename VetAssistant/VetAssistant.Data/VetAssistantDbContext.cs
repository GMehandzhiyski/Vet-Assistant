namespace VetAssistant.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using VetAssistant.Data.Models;

    public class VetAssistantDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {

        public VetAssistantDbContext()
        {

        }

        public VetAssistantDbContext(DbContextOptions options)
            : base(options)
        {

        }


    }
}
