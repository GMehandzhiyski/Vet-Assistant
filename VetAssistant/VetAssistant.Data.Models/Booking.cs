using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Booking;

namespace VetAssistant.Data.Models
{
    public class Booking
    {
        [Key]
        [Comment("BookingInterventionId")]
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
        public TypeIntervention TypeInspection { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        [Comment("Description")]
        public string Description { get; set; } = string.Empty;

        [Comment("BookingInterventionSoftDeleted")]
        public bool IsDeleted { get; set; } = false;

        [Comment("CollectionOfDoctorBookings")]
        public virtual ICollection<DoctorBookings> DoctorBookings { get; set; } = new List<DoctorBookings>();
    }
}
