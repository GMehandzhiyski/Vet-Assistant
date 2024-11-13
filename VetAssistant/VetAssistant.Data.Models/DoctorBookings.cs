namespace VetAssistant.Data.Models
{
    public class DoctorBookings
    {
        public Guid DoctorId { get; set; }

        public virtual Doctor DoctorName { get; set; } = null!;

        public Guid BookingId { get; set; }

        public virtual Booking BookingName { get; set; } = null!;
    }
}
