using ShortLinkForwarder.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ShortLinkForwarder.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ShortLinkForwarderEntityFrameworkCoreDbMigrationsModule),
        typeof(ShortLinkForwarderApplicationContractsModule)
        )]
    public class ShortLinkForwarderDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
