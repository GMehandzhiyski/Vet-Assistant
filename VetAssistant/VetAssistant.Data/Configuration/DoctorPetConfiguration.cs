using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class DoctorPetConfiguration : IEntityTypeConfiguration<DoctorPet>
    {
        public void Configure(EntityTypeBuilder<DoctorPet> builder)
        {
            builder
                .HasKey(dp => new { dp.DoctorId, dp.PetId });

            builder
                .HasOne(d => d.Doctor)
                .WithMany(dp => dp.DoctorPets)
                .HasForeignKey(dp => dp.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.Pet)
                .WithMany(dp => dp.DoctorPets)
                .HasForeignKey(p => p.PetId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
