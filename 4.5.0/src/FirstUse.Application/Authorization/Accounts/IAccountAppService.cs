using System.Threading.Tasks;
using Abp.Application.Services;
using FirstUse.Authorization.Accounts.Dto;

namespace FirstUse.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
