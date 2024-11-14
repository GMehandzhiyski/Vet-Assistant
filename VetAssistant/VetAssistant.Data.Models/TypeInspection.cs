using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class TypeInspection
    {
        [Key]
        [Comment("TypeInspectionId")]
        public Guid Id { get; set; }

        [Required]
        [Comment("TypeInterventionName")]
        public string Name { get; set; } = null!;

        [Comment("TYpeInspectionCollection")]
        public virtual ICollection<Type> Types { get; set; } = null!;
    }
}
