using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Prolix.Configuration.Dto;

namespace Prolix.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProlixAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
