using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ShortLinkForwarder.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ShortLinkForwarderMigrationsDbContextFactory : IDesignTimeDbContextFactory<ShortLinkForwarderMigrationsDbContext>
    {
        public ShortLinkForwarderMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ShortLinkForwarderMigrationsDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new ShortLinkForwarderMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
