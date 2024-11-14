using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetAssistant.Data.Models
{
    public class UserDetails
    {
        [Key]
        [Comment("UserId")]
        public Guid Id { get; set; }

        [Required]
        [Comment("FirstName")]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Comment("LastName")]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Comment("PhoneNumber")]
        [MaxLength(50)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("CountryId")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;


        [Required]
        [Comment("Town")]
        [MaxLength(50)]
        public string Town { get; set; } = string.Empty;

        [Required]
        [Comment("Address")]
        [MaxLength(50)]
        public string Address { get; set; } = null!;

        [Required]
        [Comment("ImageUrl")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("UserDetailsSoftDeleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
