using System.Threading.Tasks;
using ASPNetCoreAngularApp.Configuration.Dto;

namespace ASPNetCoreAngularApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
