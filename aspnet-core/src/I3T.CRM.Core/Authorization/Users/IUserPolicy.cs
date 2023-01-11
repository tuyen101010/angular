using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace I3T.CRM.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
