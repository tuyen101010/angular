using System.Threading.Tasks;
using I3T.CRM.Sessions.Dto;

namespace I3T.CRM.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
