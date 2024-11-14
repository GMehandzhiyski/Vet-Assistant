using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static VetAssistant.Common.ValidationConstants.TypeInspection;

namespace VetAssistant.Data.Models
{
    public class TypeInspection
    {
        [Key]
        [Comment("TypeInspectionId")]
        public Guid Id { get; set; }

        [Required]
        [Comment("TypeInterventionName")]
        [MaxLength(NameMaxLenght)]
        public string Name { get; set; } = null!;

        [Comment("TYpeInspectionCollection")]
        public virtual ICollection<TypeInspection> TypeInspections { get; set; } = null!;
    }
}
