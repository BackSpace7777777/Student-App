using Abp.Application.Services;
using Abp.Application.Services.Dto;
using StudentApp.MultiTenancy.Dto;

namespace StudentApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
