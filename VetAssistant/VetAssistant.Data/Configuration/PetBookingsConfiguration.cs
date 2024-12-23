﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class PetBookingsConfiguration : IEntityTypeConfiguration<PetBooking>
    {
        public void Configure(EntityTypeBuilder<PetBooking> builder)
        {
            builder
                .HasKey(pb => new { pb.PetId, pb.BookingId });

            builder
                .HasOne(p => p.Pet)
                .WithMany(pb => pb.PetBookings)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(b => b.Booking)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
