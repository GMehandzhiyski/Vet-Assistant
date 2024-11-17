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

            builder
                .HasOne(d => d.Doctor)
                .WithMany(di => di.DoctorInterventions)
                .HasForeignKey(d => d.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(i => i.Intervention)
                .WithMany()
                .HasForeignKey(i => i.InterventionId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
