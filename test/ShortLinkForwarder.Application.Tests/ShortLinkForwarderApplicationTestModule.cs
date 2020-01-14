using Volo.Abp.Modularity;

namespace ShortLinkForwarder
{
    [DependsOn(
        typeof(ShortLinkForwarderApplicationModule),
        typeof(ShortLinkForwarderDomainTestModule)
        )]
    public class ShortLinkForwarderApplicationTestModule : AbpModule
    {

    }
}