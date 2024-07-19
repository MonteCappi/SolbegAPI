using Volo.Abp.Settings;

namespace SolbegAPI.Settings;

public class SolbegAPISettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SolbegAPISettings.MySetting1));
    }
}
