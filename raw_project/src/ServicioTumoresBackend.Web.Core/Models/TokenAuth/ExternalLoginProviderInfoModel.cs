using Abp.AutoMapper;
using ServicioTumoresBackend.Authentication.External;

namespace ServicioTumoresBackend.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
