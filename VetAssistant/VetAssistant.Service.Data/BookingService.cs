using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;


namespace VetAssistant.Service.Data
{
    public class BookingService : BaseService, IBookingService
    {
        private readonly IRepository<Booking, Guid> bookingRepository;

        public BookingService(IRepository<Booking, Guid> _bookingRepository)
        {
            bookingRepository = _bookingRepository;
        }


    }
}
