using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Clinic;

namespace VetAssistant.Data.Models
{
    public class Clinic : BaseDeletableModel<Clinic>
    {
        public Clinic()
        {
            ClinicDoctors = new List<ClinicDoctor>();
        }

        [Required]
        [Comment("Clinic Name")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Clinic Town")]
        [MaxLength(TownMaxLenght)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("Clinic Address")]
        [MaxLength(AddressMaxLenght)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Comment("Country Id")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required]
        [Comment("Clinic Email")]
        [MaxLength(EmailMaxLenght)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Comment("Clinic Phone")]
        [MaxLength(PhoneNumberMaxLenght)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [Comment("Clinic Working Time")]
        [MaxLength(WorkingTimeMaxLenght)]
        public string WorkingTime { get; set; } = null!;

        [Comment("Collection Of Clinics Doctors")]
        public virtual ICollection<ClinicDoctor> ClinicDoctors { get; set; }

    }
}
