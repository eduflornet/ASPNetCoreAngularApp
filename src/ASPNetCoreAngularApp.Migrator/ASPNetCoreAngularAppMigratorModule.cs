using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNetCoreAngularApp.Configuration;
using ASPNetCoreAngularApp.EntityFrameworkCore;
using ASPNetCoreAngularApp.Migrator.DependencyInjection;

namespace ASPNetCoreAngularApp.Migrator
{
    [DependsOn(typeof(ASPNetCoreAngularAppEntityFrameworkModule))]
    public class ASPNetCoreAngularAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ASPNetCoreAngularAppMigratorModule(ASPNetCoreAngularAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ASPNetCoreAngularAppMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ASPNetCoreAngularAppConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularAppMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
