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
        }
    }
}
