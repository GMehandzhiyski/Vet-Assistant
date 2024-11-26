using Microsoft.EntityFrameworkCore;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class DoctorBookingConfiguration : IEntityTypeConfiguration<DoctorBooking>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DoctorBooking> builder)
        {
            builder
                .HasKey(db => new { db.DoctorId, db.BookingId });

            builder
                .HasOne(db => db.Doctor)
                .WithMany(d => d.DoctorBookings)
                .HasForeignKey(db => db.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(db => db.Booking)
                .WithMany()
                .HasForeignKey(db => db.BookingId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
