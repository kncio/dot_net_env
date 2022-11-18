using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ServicioTumoresBackend.Authorization.Roles;
using ServicioTumoresBackend.Authorization.Users;
using ServicioTumoresBackend.MultiTenancy;

namespace ServicioTumoresBackend.EntityFrameworkCore
{
    public class ServicioTumoresBackendDbContext : AbpZeroDbContext<Tenant, Role, User, ServicioTumoresBackendDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ServicioTumoresBackendDbContext(DbContextOptions<ServicioTumoresBackendDbContext> options)
            : base(options)
        {
        }
    }
}
