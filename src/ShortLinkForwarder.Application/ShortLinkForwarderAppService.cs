using System;
using System.Collections.Generic;
using System.Text;
using ShortLinkForwarder.Localization;
using Volo.Abp.Application.Services;

namespace ShortLinkForwarder
{
    /* Inherit your application services from this class.
     */
    public abstract class ShortLinkForwarderAppService : ApplicationService
    {
        protected ShortLinkForwarderAppService()
        {
            LocalizationResource = typeof(ShortLinkForwarderResource);
        }
    }
}
