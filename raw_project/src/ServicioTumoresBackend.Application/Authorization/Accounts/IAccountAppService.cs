using System.Threading.Tasks;
using Abp.Application.Services;
using ServicioTumoresBackend.Authorization.Accounts.Dto;

namespace ServicioTumoresBackend.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
