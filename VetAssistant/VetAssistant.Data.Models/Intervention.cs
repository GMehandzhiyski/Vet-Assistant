using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetAssistant.Data.Models
{
    public class Intervention
    {
        [Key]
        [Comment("InterventionId")]
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
        public UserDetails UserDetails { get; set; } = null!;

        [Required]
        [Comment("PetId")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        [ForeignKey(nameof(PetId))]
        public Pet Pet { get; set; } = null!;

        [Required]
        [Comment("DoctorId")]
        public Guid DoctorId { get; set; }

        [Required]
        [Comment("Doctor")]
        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("TypeOfInspection")]
        public Guid TypeInspectionId { get; set; }

        [Required]
        [Comment("TypeOfInspection")]
        [ForeignKey(nameof(TypeInspectionId))]
        public TypeInspection TypeInspection { get; set; } = null!;

        [Required]
        [Comment("Description")]
        [MaxLength()]
        public string DescriptionFromDoctor { get; set; } = string.Empty;

        [Required]
        [Comment("PriceForIntervention")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Description")]
        [MaxLength()]
        public string DescriptionFromUSer { get; set; } = string.Empty;

        [Comment("InterventionStatus")]
        public bool IsInterventionDone { get; set; } = false;

        [Comment("BookingInterventionSoftDeleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
