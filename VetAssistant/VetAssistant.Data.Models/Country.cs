using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class Country
    {
        [Key]
        [Comment("CountryId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Comment("CountryName")]
        [MaxLength(70)]
        public string Name { get; set; } = string.Empty;

        [Comment("CountryISOCode")]
        [MaxLength(5)]
        public string Code { get; set; } = string.Empty;

        [Comment("Collection of Countries")]
        public virtual ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
