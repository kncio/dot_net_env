using Abp.Application.Services;
using ServicioTumoresBackend.MultiTenancy.Dto;

namespace ServicioTumoresBackend.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

