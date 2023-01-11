using System.Threading.Tasks;
using Abp.Application.Services;

namespace I3T.CRM.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
