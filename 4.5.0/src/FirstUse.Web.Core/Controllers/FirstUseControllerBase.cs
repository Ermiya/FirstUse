using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FirstUse.Controllers
{
    public abstract class FirstUseControllerBase: AbpController
    {
        protected FirstUseControllerBase()
        {
            LocalizationSourceName = FirstUseConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
