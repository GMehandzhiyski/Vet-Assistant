using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class DoctorPet
    {
        [Required]
        [Comment("DoctorId")]
        public Guid DoctorId { get; set; }

        [Required]
        [Comment("Doctor")]
        public virtual Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("PetId")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        public virtual Pet Pet { get; set; } = null!;
    }
}
