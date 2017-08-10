using Prolix.Configuration;
using Prolix.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Prolix.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProlixDbContextFactory : IDbContextFactory<ProlixDbContext>
    {
        public ProlixDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ProlixDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProlixDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProlixConsts.ConnectionStringName));
            
            return new ProlixDbContext(builder.Options);
        }
    }
}