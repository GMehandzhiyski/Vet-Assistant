using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class UserDetailsConfiguration : IEntityTypeConfiguration<UserDetails>
    {
        public void Configure(EntityTypeBuilder<UserDetails> builder)
        {
            builder
                 .HasOne(ud => ud.Country)
                 .WithMany()
                 .HasForeignKey(ud => ud.CountryId)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
