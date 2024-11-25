using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Pet;

namespace VetAssistant.Data.Models
{
    public class Pet : BaseDeletableModel<Pet>
    {
        public Pet()
        {
            PetInterventions = new List<PetIntervention>();

            PetBookings = new List<PetBooking>();
        }

        [Required]
        [Comment("Pet Name")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Pet Species")]
        [MaxLength(SpeciesMaxLenght)]
        public string Species { get; set; } = string.Empty;

        [Comment("Pet Breed")]
        [MaxLength(BreedMaxLenght)]
        public string Breed { get; set; } = string.Empty;

        [Required]
        [Comment("Gender Id")]
        public Guid GenderId { get; set; }

        [Required]
        [Comment("Gender")]
        [ForeignKey(nameof(GenderId))]
        public Gender Gender { get; set; } = null!;

        [Required]
        [Comment("Country Id")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Comment("PetDate Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Comment("PetNumber Of Passport")]
        public int PassportNumber { get; set; }

        [Comment("Pet Transponder Alphanumeric Code")]
        [MaxLength(TransponderCodeLocationMaxLenght)]
        public string TransponderCode { get; set; } = string.Empty;

        [Comment("Pet Location Of The Transponder")]
        [MaxLength(TransponderLocationMaxLenght)]
        public string TransponderLocation { get; set; } = string.Empty;

        [Comment("Pet Image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("Pet Additional Details")]
        [MaxLength(DetailsLocationMaxLenght)]
        public string Details { get; set; } = string.Empty;

        [Comment("Collection Of Pet Intervention")]
        public virtual ICollection<PetIntervention> PetInterventions { get; set; }

        [Comment("Collection Of Pet Intervention")]
        public virtual ICollection<PetBooking> PetBookings { get; set; }
    }
}

