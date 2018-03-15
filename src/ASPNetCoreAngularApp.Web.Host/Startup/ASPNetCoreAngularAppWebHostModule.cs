using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNetCoreAngularApp.Configuration;

namespace ASPNetCoreAngularApp.Web.Host.Startup
{
    [DependsOn(
       typeof(ASPNetCoreAngularAppWebCoreModule))]
    public class ASPNetCoreAngularAppWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ASPNetCoreAngularAppWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularAppWebHostModule).GetAssembly());
        }
    }
}
