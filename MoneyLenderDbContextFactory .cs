using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MoneyLenderBackend {
    public class MoneyLenderDbContextFactory : IDesignTimeDbContextFactory<MoneyLenderContext> {
        public MoneyLenderContext CreateDbContext (string[] args) {
            IConfigurationRoot configuration = new ConfigurationBuilder ()
                .SetBasePath (Directory.GetCurrentDirectory ())
                .AddJsonFile ("appsettings.json")
                .Build ();

            var builder = new DbContextOptionsBuilder<MoneyLenderContext> ();

            var connectionString = configuration["DB:ConnectionString"];

            builder.UseSqlServer (connectionString);

            return new MoneyLenderContext (builder.Options);
        }
    }
}