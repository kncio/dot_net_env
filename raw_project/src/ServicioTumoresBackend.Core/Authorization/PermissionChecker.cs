using Abp.Authorization;
using ServicioTumoresBackend.Authorization.Roles;
using ServicioTumoresBackend.Authorization.Users;

namespace ServicioTumoresBackend.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
