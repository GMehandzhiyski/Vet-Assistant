using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class PetBookingsConfiguration : IEntityTypeConfiguration<PetBookings>
    {
        public void Configure(EntityTypeBuilder<PetBookings> builder)
        {
            builder
                .HasKey(pb => new { pb.PetId, pb.BookingId });
        }
    }
}
