using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class ClinicService : BaseService, IClinicService
    {
        private readonly IRepository<Clinic, Guid> clinicRepository;

        public ClinicService(IRepository<Clinic, Guid> _clinicRepository)
        {
            clinicRepository = _clinicRepository;
        }
    }
}
