using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ASPNetCoreAngularApp.Configuration;
using ASPNetCoreAngularApp.Web;

namespace ASPNetCoreAngularApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ASPNetCoreAngularAppDbContextFactory : IDesignTimeDbContextFactory<ASPNetCoreAngularAppDbContext>
    {
        public ASPNetCoreAngularAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ASPNetCoreAngularAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ASPNetCoreAngularAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ASPNetCoreAngularAppConsts.ConnectionStringName));

            return new ASPNetCoreAngularAppDbContext(builder.Options);
        }
    }
}
