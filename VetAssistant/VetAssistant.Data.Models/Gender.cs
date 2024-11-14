using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.Gender;

namespace VetAssistant.Data.Models
{
    public class Gender
    {
        [Key]
        [Comment("PetGenderId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("GenderName")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Comment("Collection of Genders")]
        public ICollection<Gender> Genders { get; set; } = new List<Gender>();
    }
}
