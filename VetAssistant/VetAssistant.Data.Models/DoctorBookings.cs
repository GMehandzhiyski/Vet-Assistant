namespace VetAssistant.Data.Models
{
    public class DoctorBookings
    {
        public virtual Guid DoctorId { get; set; }

        public virtual string DoctorName { get; set; } = null!;


    }
}
