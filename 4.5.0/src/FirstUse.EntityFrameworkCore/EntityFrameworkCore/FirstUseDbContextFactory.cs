using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FirstUse.Configuration;
using FirstUse.Web;

namespace FirstUse.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FirstUseDbContextFactory : IDesignTimeDbContextFactory<FirstUseDbContext>
    {
        public FirstUseDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FirstUseDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FirstUseDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FirstUseConsts.ConnectionStringName));

            return new FirstUseDbContext(builder.Options);
        }
    }
}
