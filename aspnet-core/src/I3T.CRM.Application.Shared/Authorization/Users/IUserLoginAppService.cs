using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using I3T.CRM.Authorization.Users.Dto;

namespace I3T.CRM.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input);
    }
}
