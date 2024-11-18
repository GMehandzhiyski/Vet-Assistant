using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class InterventionService : BaseService, IInterventionService
    {
        private readonly IRepository<Intervention, Guid> interventionRepository;

        public InterventionService(IRepository<Intervention, Guid> _interventionRepository)
        {
            interventionRepository = _interventionRepository;
        }
    }
}
