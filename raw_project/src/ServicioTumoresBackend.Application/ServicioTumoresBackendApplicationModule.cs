using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ServicioTumoresBackend.Authorization;

namespace ServicioTumoresBackend
{
    [DependsOn(
        typeof(ServicioTumoresBackendCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ServicioTumoresBackendApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ServicioTumoresBackendAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ServicioTumoresBackendApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
