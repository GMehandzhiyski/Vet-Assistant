using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class PetService : BaseService, IPetService
    {
        public PetService(VetAssistantDbContext context) : base(context)
        {
        }
    }
}
