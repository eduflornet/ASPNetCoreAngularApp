using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ASPNetCoreAngularApp.Authorization.Roles;
using ASPNetCoreAngularApp.Authorization.Users;
using ASPNetCoreAngularApp.MultiTenancy;

namespace ASPNetCoreAngularApp.EntityFrameworkCore
{
    public class ASPNetCoreAngularAppDbContext : AbpZeroDbContext<Tenant, Role, User, ASPNetCoreAngularAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ASPNetCoreAngularAppDbContext(DbContextOptions<ASPNetCoreAngularAppDbContext> options)
            : base(options)
        {
        }
    }
}
