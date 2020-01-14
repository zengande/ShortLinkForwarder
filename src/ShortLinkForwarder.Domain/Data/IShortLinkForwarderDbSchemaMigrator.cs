using System.Threading.Tasks;

namespace ShortLinkForwarder.Data
{
    public interface IShortLinkForwarderDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
