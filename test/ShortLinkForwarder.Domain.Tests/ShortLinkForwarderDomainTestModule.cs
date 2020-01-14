using ShortLinkForwarder.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ShortLinkForwarder
{
    [DependsOn(
        typeof(ShortLinkForwarderEntityFrameworkCoreTestModule)
        )]
    public class ShortLinkForwarderDomainTestModule : AbpModule
    {

    }
}