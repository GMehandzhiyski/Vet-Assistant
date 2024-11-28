using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.Clinic;
using static VetAssistant.Common.ValidationMessages.Clinic;

namespace VetAssistant.Web.ViewModels.Clinic
{
    public class AddClinicFormModel
    {
        [Comment("Identifier")]
        public string Id { get; set; } = null!;

        [Comment("Date of creation")]
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Comment("Last date of modification")]
        public DateTime? ModifiedOn { get; set; }

        [Comment("Deleted status")]
        public bool IsDeleted { get; set; }

        [Comment("Date of deleting")]
        public DateTime? DeletedOn { get; set; }

        [Required(ErrorMessage = ErrorMessageName)]
        [Comment("Clinic Name")]
        [StringLength(NameMaxLenght,
            MinimumLength = NameMinLenght,
            ErrorMessage = ErrorMessageNameLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Clinic Town")]
        [MaxLength(TownMaxLenght)]
        public string Town { get; set; } = string.Empty;

        //[Required]
        //[Comment("Clinic Address")]
        //[MaxLength(AddressMaxLenght)]
        //public string Address { get; set; } = string.Empty;

        //[Required]
        //[Comment("Country Id")]
        //public Guid CountryId { get; set; }

        //[Required]
        //[Comment("Country")]
        //[ForeignKey(nameof(CountryId))]
        //public Country Country { get; set; } = null!;

        //[Required]
        //[Comment("Clinic Email")]
        //[MaxLength(EmailMaxLenght)]
        //public string Email { get; set; } = string.Empty;

        //[Required]
        //[Comment("Clinic Phone")]
        //[MaxLength(PhoneNumberMaxLenght)]
        //public string PhoneNumber { get; set; } = null!;

        //[Required]
        //[Comment("Clinic Working Time")]
        //[MaxLength(WorkingTimeMaxLenght)]
        //public string WorkingTime { get; set; } = null!;
    }
}
