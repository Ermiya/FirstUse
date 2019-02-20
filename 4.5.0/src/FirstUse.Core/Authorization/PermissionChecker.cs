using Abp.Authorization;
using FirstUse.Authorization.Roles;
using FirstUse.Authorization.Users;

namespace FirstUse.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
