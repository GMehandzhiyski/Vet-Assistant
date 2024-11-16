using Microsoft.EntityFrameworkCore;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class DoctorInterventionConfiguration : IEntityTypeConfiguration<DoctorIntervention>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DoctorIntervention> builder)
        {
            builder
                 .HasKey(di => new { di.DoctorId, di.InterventionId });

        }
    }
}
