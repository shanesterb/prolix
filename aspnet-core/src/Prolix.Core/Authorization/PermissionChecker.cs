using Abp.Authorization;
using Prolix.Authorization.Roles;
using Prolix.Authorization.Users;

namespace Prolix.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
