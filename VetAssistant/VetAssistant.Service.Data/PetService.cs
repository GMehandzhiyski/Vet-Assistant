using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class PetService : BaseService, IPetService
    {
        private readonly IRepository<Pet, Guid> petRepository;

        public PetService(IRepository<Pet, Guid> _petRepository)
        {
            petRepository = _petRepository;
        }
    }
}
