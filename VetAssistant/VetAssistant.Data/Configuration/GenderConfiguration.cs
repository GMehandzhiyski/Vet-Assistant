using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VetAssistant.Data.Models;

namespace VetAssistant.Data.Configuration
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder
                .HasData(GenerateGender());
        }

        private IEnumerable<Gender> GenerateGender()
        {
            IEnumerable<Gender> genders = new List<Gender>()
            {
                new Gender(){ Name = "Male"},
                new Gender(){ Name = "Female"}
            };

            return genders;
        }
    }
}
