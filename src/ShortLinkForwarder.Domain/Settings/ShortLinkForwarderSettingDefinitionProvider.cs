using Volo.Abp.Settings;

namespace ShortLinkForwarder.Settings
{
    public class ShortLinkForwarderSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ShortLinkForwarderSettings.MySetting1));
        }
    }
}
