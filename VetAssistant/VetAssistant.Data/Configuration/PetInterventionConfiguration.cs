using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class PetInterventionConfiguration : IEntityTypeConfiguration<PetIntervention>
    {
        public void Configure(EntityTypeBuilder<PetIntervention> builder)
        {
            builder
                 .HasKey(ip => new { ip.PetId, ip.InterventionId });
        }
    }
}
