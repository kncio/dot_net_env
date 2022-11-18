using System.Threading.Tasks;
using Abp.Application.Services;
using ServicioTumoresBackend.Sessions.Dto;

namespace ServicioTumoresBackend.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
