using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class UserDetailsPet
    {
        [Required]
        [Comment("UserDetailsId")]
        public Guid UserId { get; set; }

        [Required]
        [Comment("UserDetails")]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [Comment("PetId")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        public virtual Pet Pet { get; set; } = null!;
    }
}
