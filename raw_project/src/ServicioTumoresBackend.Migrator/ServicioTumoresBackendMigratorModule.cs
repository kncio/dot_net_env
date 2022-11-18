using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ServicioTumoresBackend.Configuration;
using ServicioTumoresBackend.EntityFrameworkCore;
using ServicioTumoresBackend.Migrator.DependencyInjection;

namespace ServicioTumoresBackend.Migrator
{
    [DependsOn(typeof(ServicioTumoresBackendEntityFrameworkModule))]
    public class ServicioTumoresBackendMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ServicioTumoresBackendMigratorModule(ServicioTumoresBackendEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ServicioTumoresBackendMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ServicioTumoresBackendConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(ServicioTumoresBackendMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
