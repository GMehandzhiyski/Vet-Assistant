using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.Gender;

namespace VetAssistant.Data.Models
{
    public class Gender
    {
        [Key]
        [Comment("Pet Gender Id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("Gender Name")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;
    }
}
