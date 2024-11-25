using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Booking;

namespace VetAssistant.Data.Models
{
    public class Booking : BaseDeletableModel<Booking>
    {
        [Required]
        [Comment("Date Of Intervention")]
        public DateTime Date { get; set; }

        [Required]
        [Comment("User Id")]
        public Guid UserId { get; set; }

        [Required]
        [Comment("User")]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [Comment("Pet Id")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        [ForeignKey(nameof(PetId))]
        public Pet Pet { get; set; } = null!;

        [Required]
        [Comment("Doctor Id")]
        public Guid DoctorId { get; set; }

        [Required]
        [Comment("Doctor")]
        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("Type Of Inspection")]
        public Guid TypeInspectionId { get; set; }

        [Required]
        [Comment("Type Of Inspection")]
        [ForeignKey(nameof(TypeInspectionId))]
        public TypeIntervention TypeInspection { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        [Comment("Description")]
        public string Description { get; set; } = string.Empty;
    }
}
