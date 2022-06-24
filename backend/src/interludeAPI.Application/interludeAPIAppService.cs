using System;
using System.Collections.Generic;
using System.Text;
using interludeAPI.Localization;
using Volo.Abp.Application.Services;

namespace interludeAPI;

/* Inherit your application services from this class.
 */
public abstract class interludeAPIAppService : ApplicationService
{
    protected interludeAPIAppService()
    {
        LocalizationResource = typeof(interludeAPIResource);
    }
}
