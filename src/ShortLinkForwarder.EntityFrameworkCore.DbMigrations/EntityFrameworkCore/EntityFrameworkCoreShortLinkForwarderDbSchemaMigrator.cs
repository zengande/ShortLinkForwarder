using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShortLinkForwarder.Data;
using Volo.Abp.DependencyInjection;

namespace ShortLinkForwarder.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreShortLinkForwarderDbSchemaMigrator 
        : IShortLinkForwarderDbSchemaMigrator, ITransientDependency
    {
        private readonly ShortLinkForwarderMigrationsDbContext _dbContext;

        public EntityFrameworkCoreShortLinkForwarderDbSchemaMigrator(ShortLinkForwarderMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}