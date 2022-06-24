using interludeAPI.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace interludeAPI.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class interludeAPIPageModel : AbpPageModel
{
    protected interludeAPIPageModel()
    {
        LocalizationResourceType = typeof(interludeAPIResource);
    }
}
