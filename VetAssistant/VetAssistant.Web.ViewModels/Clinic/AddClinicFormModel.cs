using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.Clinic;
using static VetAssistant.Common.ValidationMessages.Clinic;

namespace VetAssistant.Web.ViewModels.Clinic
{
    public class AddClinicFormModel
    {
        public AddClinicFormModel()
        {
            Countries = new List<CountryViewModel>();
        }

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

        [Required(ErrorMessage = ErrorMessageTown)]
        [Comment("Clinic Town")]
        [StringLength(TownMaxLenght,
            MinimumLength = TownMinLenght,
            ErrorMessage = ErrorMessageTownLength)]
        public string Town { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessageAddress)]
        [Comment("Clinic Address")]
        [StringLength(AddressMaxLenght,
            MinimumLength = AddressMinLenght)]
        public string Address { get; set; } = string.Empty;

        [Comment("Country Id")]
        public Guid CountryId { get; set; }

        [Required(ErrorMessage = ErrorMessageEmail)]
        [Comment("Clinic Email")]
        [StringLength(EmailMaxLenght,
            MinimumLength = EmailMinLenght,
            ErrorMessage = ErrorMessageEmailLength)]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = ErrorMessagePhoneNumber)]
        [Comment("Clinic Phone Number")]
        [StringLength(PhoneNumberMaxLenght,
            MinimumLength = PhoneNumberMinLenght,
            ErrorMessage = ErrorMessagePhoneNumberLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = ErrorMessageWorkingTime)]
        [Comment("Clinic Working Time")]
        [StringLength(WorkingTimeMaxLenght,
            MinimumLength = WorkingTimeMinLenght,
            ErrorMessage = ErrorMessageWorkingTimeLenght)]
        public string WorkingTime { get; set; } = null!;

        public ICollection<CountryViewModel> Countries { get; set; }
    }
}
