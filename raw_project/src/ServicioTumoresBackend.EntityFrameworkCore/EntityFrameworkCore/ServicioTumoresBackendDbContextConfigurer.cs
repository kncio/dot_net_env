using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ServicioTumoresBackend.EntityFrameworkCore
{
    public static class ServicioTumoresBackendDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ServicioTumoresBackendDbContext> builder, string connectionString)
        {
           builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ServicioTumoresBackendDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
