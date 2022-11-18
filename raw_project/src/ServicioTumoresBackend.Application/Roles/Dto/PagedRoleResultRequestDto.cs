using Abp.Application.Services.Dto;

namespace ServicioTumoresBackend.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

