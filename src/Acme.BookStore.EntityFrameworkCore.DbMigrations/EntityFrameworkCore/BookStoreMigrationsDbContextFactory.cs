using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Volo.Abp.IdentityServer;

namespace Acme.BookStore.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class BookStoreMigrationsDbContextFactory : IDesignTimeDbContextFactory<BookStoreMigrationsDbContext>
    {
        public BookStoreMigrationsDbContext CreateDbContext(string[] args)
        {
            AbpIdentityServerDbProperties.DbTablePrefix = "MyIdentityServer";

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<BookStoreMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new BookStoreMigrationsDbContext(builder.Options);
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
