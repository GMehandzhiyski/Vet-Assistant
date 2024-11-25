using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VetAssistant.Data.Models
{
    public class ClinicDoctor
    {
        [Required]
        [Comment("Clinic Id")]
        public Guid ClinicId { get; set; }

        [Required]
        [Comment("Clinic")]
        public virtual Clinic Clinic { get; set; } = null!;

        [Required]
        [Comment("Doctor Id")]
        public Guid DoctorId { get; set; }

        [Required]
        [Comment("Doctor")]
        public virtual Doctor Doctor { get; set; } = null!;
    }
}
