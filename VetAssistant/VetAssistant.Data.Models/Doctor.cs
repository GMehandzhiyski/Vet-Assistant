using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Doctor;

namespace VetAssistant.Data.Models
{
    [PrimaryKey(nameof(Id), nameof(CountryId))]

    public class Doctor
    {
        [Key]
        [Comment("DoctorId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("DoctorFirstName")]
        [MaxLength(FirstNameMaxLenght)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorLastName")]
        [MaxLength(LastNameMaxLenght)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorDateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Comment("DoctorEmailAddress")]
        [MaxLength(EmailMaxLenght)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Comment("PhoneNumber")]
        [MaxLength(PhoneNumberMaxLenght)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("CountryId")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required]
        [Comment("DoctorTown")]
        [MaxLength(TownMaxLenght)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorEducation")]
        [MaxLength(EducationMaxLenght)]
        public string Education { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorSpecialty")]
        [MaxLength(SpecialtyMaxLenght)]
        public string Specialty { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorExperience")]
        [MaxLength(ExperienceMaxLenght)]
        public string Experience { get; set; } = string.Empty;

        [Comment("DoctorDetails")]
        [MaxLength(500)]
        public string Details { get; set; } = string.Empty;

        [Comment("DoctorImage")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("DoctorSoftDelete")]
        public bool IsDeleted { get; set; } = false;

        [Comment("CollectionOfClinicDoctor")]
        public virtual ICollection<ClinicDoctor> ClinicsDoctors { get; set; } = new List<ClinicDoctor>();

        [Comment("CollectionOfDoctorPet")]
        public virtual ICollection<DoctorPet> DoctorsPets { get; set; } = new List<DoctorPet>();

        [Comment("CollectionOfDoctorIntervention")]
        public virtual ICollection<DoctorIntervention> DoctorsInterventions { get; set; } = new List<DoctorIntervention>();
    }
}
