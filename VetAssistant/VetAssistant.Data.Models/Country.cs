using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.Country;

namespace VetAssistant.Data.Models
{
    public class Country
    {
        [Key]
        [Comment("Country Id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Comment("Country Name")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Comment("Country ISOCode")]
        [MaxLength(CodeMaxLenght)]
        public string Code { get; set; } = string.Empty;

    }
}
