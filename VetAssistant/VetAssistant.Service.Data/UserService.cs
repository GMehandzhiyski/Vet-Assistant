using VetAssistant.Data;
using VetAssistant.Service.Data.Contracts;

namespace VetAssistant.Service.Data
{
    public class UserService : BaseService, IUserService
    {
        public UserService(VetAssistantDbContext _context)
            : base(_context)
        {
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
