using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ServicioTumoresBackend.Configuration.Dto;

namespace ServicioTumoresBackend.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ServicioTumoresBackendAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
