using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class DoctorService : BaseService, IDoctorService
    {
        private readonly IRepository<Doctor, Guid> doctorRepository;

        public DoctorService(IRepository<Doctor, Guid> _doctorRepository)
        {
            doctorRepository = _doctorRepository;
        }
    }
}
