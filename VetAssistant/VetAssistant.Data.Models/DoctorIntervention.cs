using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class DoctorIntervention
    {
        [Required]
        [Comment("DoctorId")]
        public Guid DoctorId { get; set; }

        [Required]
        [Comment("Doctor")]
        public virtual Doctor Doctor { get; set; } = null!;

        [Required]
        [Comment("InterventionId")]
        public Guid InterventionId { get; set; }

        [Required]
        [Comment("Intervention")]
        public virtual Intervention Intervention { get; set; } = null!;
    }
}
