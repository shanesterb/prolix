using System.Threading.Tasks;
using Prolix.Configuration.Dto;

namespace Prolix.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}