using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class ClinicDoctorConfiguration : IEntityTypeConfiguration<ClinicDoctor>
    {
        public void Configure(EntityTypeBuilder<ClinicDoctor> builder)
        {
            builder
                .HasKey(cd => new { cd.ClinicId, cd.DoctorId });

            builder
               .HasOne(cd => cd.Clinic)
               .WithMany(c => c.ClinicDoctors)
               .HasForeignKey(cd => cd.ClinicId)
               .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(cd => cd.Doctor)
                .WithMany(d => d.ClinicDoctors)
                .HasForeignKey(cd => cd.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
