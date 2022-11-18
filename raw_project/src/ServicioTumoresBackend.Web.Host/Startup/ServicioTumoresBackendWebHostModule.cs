using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ServicioTumoresBackend.Configuration;

namespace ServicioTumoresBackend.Web.Host.Startup
{
    [DependsOn(
       typeof(ServicioTumoresBackendWebCoreModule))]
    public class ServicioTumoresBackendWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ServicioTumoresBackendWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ServicioTumoresBackendWebHostModule).GetAssembly());
        }
    }
}
