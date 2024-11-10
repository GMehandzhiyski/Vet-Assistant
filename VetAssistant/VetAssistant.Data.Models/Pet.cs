using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static VetAssistant.Common.ValidationConstants.Pet;

namespace VetAssistant.Data.Models
{
    public class Pet
    {
        [Key]
        [Comment("PetId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("PetName")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("PetSpecies")]
        [MaxLength(SpeciesMaxLenght)]
        public string Species { get; set; } = string.Empty;

        [Comment("PetBreed")]
        [MaxLength(BreedMaxLenght)]
        public string Breed { get; set; } = string.Empty;

        [Required]
        [Comment("GenderId")]
        public Guid GenderId { get; set; }

        [Required]
        [Comment("Gender")]
        [ForeignKey(nameof(GenderId))]
        public Gender Gender { get; set; } = null!;

        [Required]
        [Comment("CountryId")]
        public Guid CountryId { get; set; }

        [Required]
        [Comment("Country")]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Comment("PetDateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Comment("PetNumberOfPassport")]
        public int PassportNumber { get; set; }

        [Comment("PetTransponderAlphanumericCode")]
        [MaxLength(TransponderCodeLocationMaxLenght)]
        public string TransponderCode { get; set; } = string.Empty;

        [Comment("PetLocationOfTheTransponder")]
        [MaxLength(TransponderLocationMaxLenght)]
        public string TransponderLocation { get; set; } = string.Empty;

        [Comment("PetImage")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("PetAdditionalDetails")]
        [MaxLength(DetailsLocationMaxLenght)]
        public string Details { get; set; } = string.Empty;

        [Comment("PetSoftDeleted")]
        public bool IsDeleted { get; set; } = false;

        [Comment("CollectionOfUserPet")]
        public virtual ICollection<UserPet> UsersPets { get; set; } = new List<UserPet>();

        [Comment("CollectionOfUserPet")]

        public virtual ICollection<DoctorPet> DoctorsPets { get; set; } = new List<DoctorPet>();

        [Comment("CollectionOfPetIntervention")]
        public virtual ICollection<PetIntervention> PetsInterventions { get; set; } = new List<PetIntervention>();
    }
}
