using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class UserDetailsPetConfiguration : IEntityTypeConfiguration<UserDetailsPet>
    {
        public void Configure(EntityTypeBuilder<UserDetailsPet> builder)
        {
            builder
                .HasKey(up => new { up.UserId, up.PetId });

            builder
                .HasOne(u => u.UserDetails)
                .WithMany(up => up.UserDetailsPets)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.Pet)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
