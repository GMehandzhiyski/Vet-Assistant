using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorSecondName")]
        [MaxLength(20)]
        public string SecondName { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorDateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Comment("DoctorEmailAddress")]
        [MaxLength(2)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Comment("PhoneNumber")]
        [MaxLength(20)]
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
        [MaxLength(40)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorEducation")]
        [MaxLength(200)]
        public string Еducation { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorSpecialty")]
        [MaxLength(200)]
        public string Specialty { get; set; } = string.Empty;

        [Required]
        [Comment("DoctorExperience")]
        [MaxLength(500)]
        public string Experience { get; set; } = string.Empty;

        [Comment("DoctorDetails")]
        [MaxLength(500)]
        public string Details { get; set; } = string.Empty;

        [Comment("DoctorImage")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("DoctorSoftDelete")]
        public bool IsDelete { get; set; } = false;

        [Comment("CollectionOfClinicDoctor")]
        public virtual ICollection<ClinicDoctor> ClinicsDoctors { get; set; } = new List<ClinicDoctor>();

        [Comment("CollectionOfDoctorPet")]
        public virtual ICollection<DoctorPet> DoctorsPets { get; set; } = new List<DoctorPet>();


        [Comment("CollectionOfDoctorIntervention")]
        public virtual ICollection<DoctorIntervention> DoctorsInterventions { get; set; } = new List<DoctorIntervention>();
    }
}
