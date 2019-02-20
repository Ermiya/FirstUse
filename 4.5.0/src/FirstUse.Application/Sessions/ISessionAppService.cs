using System.Threading.Tasks;
using Abp.Application.Services;
using FirstUse.Sessions.Dto;

namespace FirstUse.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
