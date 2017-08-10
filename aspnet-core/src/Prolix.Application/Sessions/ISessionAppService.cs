using System.Threading.Tasks;
using Abp.Application.Services;
using Prolix.Sessions.Dto;

namespace Prolix.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
