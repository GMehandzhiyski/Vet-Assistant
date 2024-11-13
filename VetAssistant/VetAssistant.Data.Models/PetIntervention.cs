using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class PetIntervention
    {
        [Required]
        [Comment("PetId")]
        public Guid PetId { get; set; }

        [Required]
        [Comment("Pet")]
        public virtual Pet Pet { get; set; } = null!;

        [Required]
        [Comment("InterventionId")]
        public Guid InterventionId { get; set; }

        [Required]
        [Comment("Intervention")]
        public virtual Intervention Intervention { get; set; } = null!;
    }
}
