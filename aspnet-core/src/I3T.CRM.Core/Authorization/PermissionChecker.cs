using Abp.Authorization;
using I3T.CRM.Authorization.Roles;
using I3T.CRM.Authorization.Users;

namespace I3T.CRM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
