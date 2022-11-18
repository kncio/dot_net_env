using Abp.MultiTenancy;
using ServicioTumoresBackend.Authorization.Users;

namespace ServicioTumoresBackend.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
