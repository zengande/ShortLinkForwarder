using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ShortLinkForwarder.Data
{
    /* This is used if database provider does't define
     * IShortLinkForwarderDbSchemaMigrator implementation.
     */
    public class NullShortLinkForwarderDbSchemaMigrator : IShortLinkForwarderDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}