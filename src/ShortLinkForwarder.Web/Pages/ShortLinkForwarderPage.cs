using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using ShortLinkForwarder.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShortLinkForwarder.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits ShortLinkForwarder.Web.Pages.ShortLinkForwarderPage
     */
    public abstract class ShortLinkForwarderPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<ShortLinkForwarderResource> L { get; set; }
    }
}
