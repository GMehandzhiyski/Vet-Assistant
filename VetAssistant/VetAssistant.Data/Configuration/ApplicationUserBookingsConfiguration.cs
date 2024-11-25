using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class ApplicationUserBookingsConfiguration : IEntityTypeConfiguration<ApplicationUserBooking>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserBooking> builder)
        {
            builder
                 .HasKey(ub => new { ub.UserDetailsId, ub.BookingId });

            builder
                .HasOne(b => b.ApplicationUser)
                .WithMany(us => us.ApplicationUserBookings)
                .HasForeignKey(ub => ub.UserDetailsId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(ub => ub.Booking)
                .WithMany()
                .HasForeignKey(ub => ub.BookingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
