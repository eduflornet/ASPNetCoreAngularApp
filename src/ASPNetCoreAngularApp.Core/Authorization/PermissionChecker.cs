using Abp.Authorization;
using ASPNetCoreAngularApp.Authorization.Roles;
using ASPNetCoreAngularApp.Authorization.Users;

namespace ASPNetCoreAngularApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
