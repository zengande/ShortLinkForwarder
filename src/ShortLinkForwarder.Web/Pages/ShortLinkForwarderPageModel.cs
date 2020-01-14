using ShortLinkForwarder.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShortLinkForwarder.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ShortLinkForwarderPageModel : AbpPageModel
    {
        protected ShortLinkForwarderPageModel()
        {
            LocalizationResourceType = typeof(ShortLinkForwarderResource);
        }
    }
}