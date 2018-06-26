using Abp.Authorization;
using StudentApp.Authorization.Roles;
using StudentApp.Authorization.Users;

namespace StudentApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
