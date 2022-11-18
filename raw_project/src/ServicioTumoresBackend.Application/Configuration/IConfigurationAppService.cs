using System.Threading.Tasks;
using ServicioTumoresBackend.Configuration.Dto;

namespace ServicioTumoresBackend.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
