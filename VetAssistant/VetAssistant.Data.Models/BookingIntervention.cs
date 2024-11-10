using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class BookingIntervention
    {
        [Key]
        [Comment("BookingIntervention")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("DateOfIntervention")]
        public DateTime Date { get; set; }

        // [Required]
        // [Comment("UserId")]

        // To be continued
    }
}
