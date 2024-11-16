using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.TypeIntervention;

namespace VetAssistant.Data.Models
{
    public class TypeIntervention
    {
        [Key]
        [Comment("TypeInspectionId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("TypeInterventionName")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = null!;
    }
}
