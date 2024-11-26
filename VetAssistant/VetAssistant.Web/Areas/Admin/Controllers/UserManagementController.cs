using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static VetAssistant.Common.DateConstants;

namespace VetAssistant.Web.Areas.Admin.Controllers
{
    [Area(AdminRoleName)]
    [Authorize(Roles = AdminRoleName)]
    public class UserManagementController
    {


    }
}
