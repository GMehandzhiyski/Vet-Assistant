using VetAssistant.Data.Models;
using VetAssistant.Data.Repository.Interfaces;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class UserService : BaseService, IUserService
    {
        private readonly IRepository<ApplicationUser, Guid> userRepository;

        public UserService(IRepository<ApplicationUser, Guid> _userRepository)
        {
            userRepository = _userRepository;
        }

        public Task<bool> AssignUserToRoleAsync(Guid userId, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveUserRoleAsync(Guid userId, string roleName)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }

}
