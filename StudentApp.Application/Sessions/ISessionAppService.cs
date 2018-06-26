using System.Threading.Tasks;
using Abp.Application.Services;
using StudentApp.Sessions.Dto;

namespace StudentApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
