using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.UserDetails;

namespace VetAssistant.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>, IAuditInfo, IDeletableEntity
    {
        [Required]
        [Comment("First Name")]
        [MaxLength(FirstNameMaxLenght)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("Last Name")]
        [MaxLength(LastNameMaxLenght)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("Country Id")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required]
        [Comment("Town")]
        [MaxLength(TownMaxLenght)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("Address")]
        [MaxLength(AddressMaxLenght)]
        public string Address { get; set; } = null!;

        [Required]
        [Comment("ImageUrl")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Date of create")]
        public DateTime CreatedOn { get; set; }

        [Comment("Date of modification")]
        public DateTime? ModifiedOn { get; set; }

        [Comment("State of delete")]
        public bool IsDeleted { get; set; }

        [Comment("Date of Delete")]
        public DateTime? DeletedOn { get; set; }

        [Comment("CollectionOfPetIntervention")]
        public virtual ICollection<ApplicationUserPet> UserDetailsPets { get; set; } = new List<ApplicationUserPet>();

        [Comment("CollectionOfPetIntervention")]
        public virtual ICollection<ApplicationUserBookings> UserBookings { get; set; } = new List<ApplicationUserBookings>();

    }
}
