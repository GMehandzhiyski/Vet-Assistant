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
        [ForeignKey(nameof(GenderId))]
        [Comment("Gender")]
        public Gender Gender { get; set; } = null!;

        [Required]
        [Comment("CountryId")]
        public Guid CountryId { get; set; }

        [Required]
        [ForeignKey(nameof(CountryId))]
        [Comment("Country")]
        public Country Country { get; set; } = null!;

        [Comment("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [Comment("NumberOfPassport")]
        public int PassportNumber { get; set; }

        [Comment("TransponderAlphanumericCode")]
        [MaxLength(TransponderCodeLocationMaxLenght)]
        public string TransponderCode { get; set; } = string.Empty;

        [Comment("LocationOfTheTransponder")]
        [MaxLength(TransponderLocationMaxLenght)]
        public string TransponderLocation { get; set; } = string.Empty;

        [Comment("PetImage")]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("AdditionalDetails")]
        [MaxLength(DetailsLocationMaxLenght)]
        public string Details { get; set; } = string.Empty;

        [Comment("SoftDeleted")]
        public bool IsDeleted { get; set; } = false;

        [Comment("CollectionOfUserPet")]
        public virtual ICollection<UserPet> UsersPets { get; set; } = new List<UserPet>();

        [Comment("CollectionOfUserPet")]

        public virtual ICollection<DoctorPet> DoctorsPets { get; set; } = new List<DoctorPet>();

        [Comment("CollectionOfPetIntervention")]
        public virtual ICollection<PetIntervention> PetsInterventions { get; set; } = new List<PetIntervention>();
    }
}
