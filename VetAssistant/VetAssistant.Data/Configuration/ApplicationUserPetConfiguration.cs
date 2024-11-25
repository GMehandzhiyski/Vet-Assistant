using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class ApplicationUserPetConfiguration : IEntityTypeConfiguration<ApplicationUserPet>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserPet> builder)
        {
            builder
                .HasKey(up => new { up.UserId, up.PetId });

            builder
                .HasOne(u => u.ApplicationUser)
                .WithMany(up => up.UserDetailsPets)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.Pet)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
