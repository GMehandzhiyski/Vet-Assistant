using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class UserBookings
    {
        [Required]
        [Comment("UserId")]
        public Guid UserDetailsId { get; set; }

        [Required]
        [Comment("UserDetails")]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [Comment("BookingId")]
        public Guid BookingId { get; set; }

        [Required]
        [Comment("Booking")]
        public virtual Booking Booking { get; set; } = null!;


    }
}
