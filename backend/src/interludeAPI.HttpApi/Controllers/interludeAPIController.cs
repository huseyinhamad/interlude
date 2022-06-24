using interludeAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace interludeAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class interludeAPIController : AbpControllerBase
{
    protected interludeAPIController()
    {
        LocalizationResource = typeof(interludeAPIResource);
    }
}
