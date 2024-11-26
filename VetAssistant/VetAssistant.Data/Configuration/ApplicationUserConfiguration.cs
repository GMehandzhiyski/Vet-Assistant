using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                 .HasOne(ud => ud.Country)
                 .WithMany()
                 .HasForeignKey(ud => ud.CountryId)
                 .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
