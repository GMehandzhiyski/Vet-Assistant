using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class DoctorBooking
    {
        [Required]
        [Comment("Doctor Id")]
        public Guid DoctorId { get; set; }

        [Required]
        [Comment("Doctor")]
        public virtual Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("Booking Id")]
        public Guid BookingId { get; set; }

        [Required]
        [Comment("Booking")]
        public virtual Booking Booking { get; set; } = null!;
    }
}
