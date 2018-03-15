using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using ASPNetCoreAngularApp.EntityFrameworkCore.Seed;

namespace ASPNetCoreAngularApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(ASPNetCoreAngularAppCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ASPNetCoreAngularAppEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ASPNetCoreAngularAppDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ASPNetCoreAngularAppDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ASPNetCoreAngularAppDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularAppEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
