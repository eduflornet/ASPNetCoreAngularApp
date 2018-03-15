using System.Threading.Tasks;
using Abp.Application.Services;
using ASPNetCoreAngularApp.Authorization.Accounts.Dto;

namespace ASPNetCoreAngularApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
