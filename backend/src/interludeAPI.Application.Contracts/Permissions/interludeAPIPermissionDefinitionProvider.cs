using interludeAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace interludeAPI.Permissions;

public class interludeAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(interludeAPIPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(interludeAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<interludeAPIResource>(name);
    }
}
