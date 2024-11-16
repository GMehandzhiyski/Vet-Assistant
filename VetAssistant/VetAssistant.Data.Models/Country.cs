using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.Country;

namespace VetAssistant.Data.Models
{
    public class Country
    {
        [Key]
        [Comment("CountryId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Comment("CountryName")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Comment("CountryISOCode")]
        [MaxLength(CodeMaxLenght)]
        public string Code { get; set; } = string.Empty;

    }
}
