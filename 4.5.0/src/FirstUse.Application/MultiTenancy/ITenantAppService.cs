using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FirstUse.MultiTenancy.Dto;

namespace FirstUse.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

