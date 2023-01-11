using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.Sessions.Dto;

namespace I3T.CRM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
