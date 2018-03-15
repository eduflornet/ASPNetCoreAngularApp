using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNetCoreAngularApp.Authorization;

namespace ASPNetCoreAngularApp
{
    [DependsOn(
        typeof(ASPNetCoreAngularAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ASPNetCoreAngularAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ASPNetCoreAngularAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ASPNetCoreAngularAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
