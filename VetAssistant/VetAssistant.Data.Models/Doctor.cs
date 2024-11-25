using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Doctor;

namespace VetAssistant.Data.Models
{
    public class Doctor : BaseDeletableModel<Doctor>
    {
        public Doctor()
        {
            DoctorPets = new List<DoctorPet>();
            DoctorInterventions = new List<DoctorIntervention>();
            DoctorBookings = new List<DoctorBooking>();
        }

        [Required]
        [Comment("Doctor First Name")]
        [MaxLength(FirstNameMaxLenght)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("Doctor Last Name")]
        [MaxLength(LastNameMaxLenght)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("Doctor Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Comment("Doctor Email Address")]
        [MaxLength(EmailMaxLenght)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Comment("Phone Number")]
        [MaxLength(PhoneNumberMaxLenght)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Country Id")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required]
        [Comment("Doctor Town")]
        [MaxLength(TownMaxLenght)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("Doctor Education")]
        [MaxLength(EducationMaxLenght)]
        public string Education { get; set; } = string.Empty;

        [Required]
        [Comment("Doctor Specialty")]
        [MaxLength(SpecialtyMaxLenght)]
        public string Specialty { get; set; } = string.Empty;

        [Required]
        [Comment("Doctor Experience")]
        [MaxLength(ExperienceMaxLenght)]
        public string Experience { get; set; } = string.Empty;

        [Comment("Doctor Details")]
        [MaxLength(DetailsMaxLenght)]
        public string Details { get; set; } = string.Empty;

        [Comment("Doctor Image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Collection Of Doctor Pet")]
        public virtual ICollection<DoctorPet> DoctorPets { get; set; }

        [Comment("Collection Of Doctor Intervention")]
        public virtual ICollection<DoctorIntervention> DoctorInterventions { get; set; }

        [Comment("Collection Of Doctor Bookings")]
        public virtual ICollection<DoctorBooking> DoctorBookings { get; set; }

    }
}
