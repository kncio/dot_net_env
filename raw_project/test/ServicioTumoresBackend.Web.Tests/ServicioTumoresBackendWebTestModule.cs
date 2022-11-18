using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ServicioTumoresBackend.EntityFrameworkCore;
using ServicioTumoresBackend.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ServicioTumoresBackend.Web.Tests
{
    [DependsOn(
        typeof(ServicioTumoresBackendWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ServicioTumoresBackendWebTestModule : AbpModule
    {
        public ServicioTumoresBackendWebTestModule(ServicioTumoresBackendEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServicioTumoresBackendWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ServicioTumoresBackendWebMvcModule).Assembly);
        }
    }
}