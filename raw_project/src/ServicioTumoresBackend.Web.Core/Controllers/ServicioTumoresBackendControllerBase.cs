using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ServicioTumoresBackend.Controllers
{
    public abstract class ServicioTumoresBackendControllerBase: AbpController
    {
        protected ServicioTumoresBackendControllerBase()
        {
            LocalizationSourceName = ServicioTumoresBackendConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
