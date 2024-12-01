using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class HomeService : BaseService, IHomeService
    {
        //?????????
        public HomeService(VetAssistantDbContext _context)
            : base(_context)
        {
        }
    }
}
