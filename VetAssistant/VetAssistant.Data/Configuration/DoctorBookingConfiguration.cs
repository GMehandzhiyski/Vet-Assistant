using Microsoft.EntityFrameworkCore;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class DoctorBookingConfiguration : IEntityTypeConfiguration<DoctorBookings>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DoctorBookings> builder)
        {
            builder
                .HasKey(db => new { db.DoctorId, db.BookingId });
        }
    }
}
