using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class InterventionService : BaseService, IInterventionService
    {
        public InterventionService(VetAssistantDbContext context)
            : base(context)
        {
        }
    }
}
