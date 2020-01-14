using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ShortLinkForwarder.EntityFrameworkCore
{
    [DependsOn(
        typeof(ShortLinkForwarderEntityFrameworkCoreModule)
        )]
    public class ShortLinkForwarderEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ShortLinkForwarderMigrationsDbContext>();
        }
    }
}
