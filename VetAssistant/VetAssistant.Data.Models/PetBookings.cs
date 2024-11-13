using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class PetBookings
    {
        [Required]
        [Comment("PetId")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        public virtual Pet Pet { get; set; } = null!;

        [Required]
        [Comment("Booking")]
        public Guid BookingId { get; set; }

        [Required]
        [Comment("Booking")]
        public virtual Booking Booking { get; set; } = null!;

    }
}
