using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class UserBookingsConfiguration : IEntityTypeConfiguration<UserBookings>
    {
        public void Configure(EntityTypeBuilder<UserBookings> builder)
        {
            builder
                 .HasKey(ub => new { ub.UserDetailsId, ub.BookingId });

            builder
                .HasOne(b => b.ApplicationUser)
                .WithMany(us => us.UserBookings)
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
