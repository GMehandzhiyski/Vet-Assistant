using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class ApplicationUserPet
    {
        [Required]
        [Comment("User Details Id")]
        public Guid ApplicationUserId { get; set; }

        [Required]
        [Comment("User Details")]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [Comment("Pet Id")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        public virtual Pet Pet { get; set; } = null!;
    }
}
