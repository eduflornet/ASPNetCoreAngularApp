using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ASPNetCoreAngularApp.Controllers
{
    public abstract class ASPNetCoreAngularAppControllerBase: AbpController
    {
        protected ASPNetCoreAngularAppControllerBase()
        {
            LocalizationSourceName = ASPNetCoreAngularAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
