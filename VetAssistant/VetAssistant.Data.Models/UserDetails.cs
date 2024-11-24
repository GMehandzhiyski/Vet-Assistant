using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.UserDetails;

namespace VetAssistant.Data.Models
{
    public class UserDetails : IdentityUser<Guid>
    {
        [Key]
        [Comment("UserId")]
        public Guid Id { get; set; }

        public UserDetails()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        [Comment("FirstName")]
        [MaxLength(FirstNameMaxLenght)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("LastName")]
        [MaxLength(LastNameMaxLenght)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("PhoneNumber")]
        [MaxLength(PhoneNumberMaxLenght)]
        public override string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("CountryId")]
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

        [Required]
        [Comment("UserDetailsSoftDeleted")]
        public bool IsDeleted { get; set; } = false;


        [Comment("CollectionOfPetIntervention")]
        public virtual ICollection<UserDetailsPet> UserDetailsPets { get; set; } = new List<UserDetailsPet>();

        [Comment("CollectionOfPetIntervention")]
        public virtual ICollection<UserBookings> UserBookings { get; set; } = new List<UserBookings>();
    }
}
