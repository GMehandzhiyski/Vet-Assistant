using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Clinic;

namespace VetAssistant.Data.Models
{
    public class Clinic
    {
        [Key]
        [Comment("ClinicId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("ClinicName")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("ClinicTown")]
        [MaxLength(TownMaxLenght)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("ClinicAddress")]
        [MaxLength(AddressMaxLenght)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Comment("CountryId")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required]
        [Comment("ClinicEmail")]
        [MaxLength(EmailMaxLenght)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Comment("ClinicPhone")]
        [MaxLength(PhoneNumberMaxLenght)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [Comment("ClinicWorkingTime")]
        [MaxLength(WorkingTimeMaxLenght)]
        public string WorkingTime { get; set; } = null!;

        [Comment("ClinicSoftDeleted")]
        public bool IsDeleted { get; set; } = false;

        [Comment("CollectionOfClinicsDoctors")]
        public virtual ICollection<ClinicDoctor> ClinicDoctors { get; set; } = new List<ClinicDoctor>();

    }
}
