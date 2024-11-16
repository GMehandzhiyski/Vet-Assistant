using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class UserDetailsApplicationUser
    {
        [Required]
        [Comment("UserId")]
        public Guid UserDetailsId { get; set; }

        [Required]
        [Comment("UserDetails")]
        public virtual UserDetails UserDetails { get; set; } = null!;

        [Required]
        [Comment("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }

        [Required]
        [Comment("ApplicationUser")]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    }
}
