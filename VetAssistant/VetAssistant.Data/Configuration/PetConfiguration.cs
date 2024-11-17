using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder
                .HasOne(g => g.Gender)
                .WithMany()
                .HasForeignKey(g => g.GenderId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(p => p.Country)
                .WithMany()
                .HasForeignKey(p => p.CountryId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
