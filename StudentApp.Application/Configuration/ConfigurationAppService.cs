using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using StudentApp.Configuration.Dto;

namespace StudentApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StudentAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
