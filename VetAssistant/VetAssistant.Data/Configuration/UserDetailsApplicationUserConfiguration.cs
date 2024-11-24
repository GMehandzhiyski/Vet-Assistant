using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class UserDetailsApplicationUserConfiguration : IEntityTypeConfiguration<UserDetailsApplicationUser>
    {
        public void Configure(EntityTypeBuilder<UserDetailsApplicationUser> builder)
        {
            builder
                .HasKey(ua => new { ua.UserDetailsId, ua.ApplicationUserId });
        }
    }
}
