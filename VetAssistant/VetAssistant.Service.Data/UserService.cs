using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository<UserDetails, Guid> userRepository;

        public UserService(IRepository<UserDetails, Guid> _userRepository)
        {
            userRepository = _userRepository;
        }

    }

}
