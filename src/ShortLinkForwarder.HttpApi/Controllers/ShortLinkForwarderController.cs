using ShortLinkForwarder.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ShortLinkForwarder.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ShortLinkForwarderController : AbpController
    {
        protected ShortLinkForwarderController()
        {
            LocalizationResource = typeof(ShortLinkForwarderResource);
        }
    }
}