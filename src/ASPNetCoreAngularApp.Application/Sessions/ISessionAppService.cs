using System.Threading.Tasks;
using Abp.Application.Services;
using ASPNetCoreAngularApp.Sessions.Dto;

namespace ASPNetCoreAngularApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
