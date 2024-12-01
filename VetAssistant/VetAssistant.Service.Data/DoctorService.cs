using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class DoctorService : BaseService, IDoctorService
    {
        public DoctorService(VetAssistantDbContext contextDoctor)
            : base(contextDoctor)
        {
        }
    }
}
