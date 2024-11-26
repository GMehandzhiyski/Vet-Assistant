using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {

            builder
                .HasOne(b => b.Pet)
                .WithMany()
                .HasForeignKey(b => b.PetId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(b => b.Doctor)
                .WithMany()
                .HasForeignKey(b => b.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(b => b.TypeInspection)
                .WithMany()
                .HasForeignKey(b => b.TypeInspectionId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
