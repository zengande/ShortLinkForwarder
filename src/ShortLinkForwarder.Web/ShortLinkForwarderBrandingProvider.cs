using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace ShortLinkForwarder.Web
{
    [Dependency(ReplaceServices = true)]
    public class ShortLinkForwarderBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ShortLinkForwarder";
    }
}
