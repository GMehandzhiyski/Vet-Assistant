using Microsoft.AspNetCore.Identity;

namespace VetAssistant.Data.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
            : base()
        {

        }

        public ApplicationRole(string roleName)
            : base(roleName)
        {

        }
    }
}
