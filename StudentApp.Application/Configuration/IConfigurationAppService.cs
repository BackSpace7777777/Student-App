using System.Threading.Tasks;
using Abp.Application.Services;
using StudentApp.Configuration.Dto;

namespace StudentApp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}