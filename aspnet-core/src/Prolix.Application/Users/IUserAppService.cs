using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Prolix.Roles.Dto;
using Prolix.Users.Dto;

namespace Prolix.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}