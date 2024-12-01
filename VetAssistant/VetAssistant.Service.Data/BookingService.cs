using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;


namespace VetAssistant.Service.Data
{
    public class BookingService : BaseService, IBookingService
    {
        public BookingService(VetAssistantDbContext contextBooking)
          : base(contextBooking)
        {
        }


    }
}
