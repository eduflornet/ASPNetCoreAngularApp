using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ASPNetCoreAngularApp.MultiTenancy.Dto;

namespace ASPNetCoreAngularApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
