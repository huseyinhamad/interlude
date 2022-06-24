using Volo.Abp.Settings;

namespace interludeAPI.Settings;

public class interludeAPISettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(interludeAPISettings.MySetting1));
    }
}
