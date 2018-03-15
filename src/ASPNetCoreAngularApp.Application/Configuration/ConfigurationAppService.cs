using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ASPNetCoreAngularApp.Configuration.Dto;

namespace ASPNetCoreAngularApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ASPNetCoreAngularAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
