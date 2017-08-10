using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Prolix.Controllers
{
    public abstract class ProlixControllerBase: AbpController
    {
        protected ProlixControllerBase()
        {
            LocalizationSourceName = ProlixConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}