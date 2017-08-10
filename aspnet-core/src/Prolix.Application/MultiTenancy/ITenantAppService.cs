using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Prolix.MultiTenancy.Dto;

namespace Prolix.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
