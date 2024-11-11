using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Required]
        [Comment("UserId")]
        public Guid UserId { get; set; }

        [Required]
        [Comment("User")]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("PetId")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        [ForeignKey(nameof(PetId))]
        public Pet Pet { get; set; } = null!;

        //[Required]
        // [Comment("")]
        // To be continued
    }
}
