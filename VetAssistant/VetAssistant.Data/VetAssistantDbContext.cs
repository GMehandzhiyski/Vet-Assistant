﻿namespace VetAssistant.Data
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

        public DbSet<>

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
