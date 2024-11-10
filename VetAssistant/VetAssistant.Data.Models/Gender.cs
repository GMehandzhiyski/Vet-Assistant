using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class Gender
    {
        [Key]
        [Comment("PetGenderId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("GenderName")]
        public string Name { get; set; } = string.Empty;

        [Comment("Collection of Genders")]
        public ICollection<Gender> Genders { get; set; } = new List<Gender>();
    }
}
