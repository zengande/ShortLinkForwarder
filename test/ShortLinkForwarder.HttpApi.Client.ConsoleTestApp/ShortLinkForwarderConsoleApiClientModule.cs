using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ShortLinkForwarder.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ShortLinkForwarderHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ShortLinkForwarderConsoleApiClientModule : AbpModule
    {
        
    }
}
