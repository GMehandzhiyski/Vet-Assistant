namespace VetAssistant.Data.Models
{
    public class ClinicDoctor
    {
        public Guid ClinicId { get; set; }

        public virtual Clinic Clinic { get; set; } = null!;

        public Guid DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; } = null!;
    }
}
