using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreAngularApp.EntityFrameworkCore
{
    public static class ASPNetCoreAngularAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ASPNetCoreAngularAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ASPNetCoreAngularAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
