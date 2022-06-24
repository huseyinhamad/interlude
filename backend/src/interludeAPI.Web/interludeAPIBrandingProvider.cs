using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace interludeAPI.Web;

[Dependency(ReplaceServices = true)]
public class interludeAPIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "interludeAPI";
}
