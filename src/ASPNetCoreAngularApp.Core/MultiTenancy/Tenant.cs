using Abp.MultiTenancy;
using ASPNetCoreAngularApp.Authorization.Users;

namespace ASPNetCoreAngularApp.MultiTenancy
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
