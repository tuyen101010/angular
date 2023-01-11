using System.Threading.Tasks;
using I3T.CRM.Authorization.Users;

namespace I3T.CRM.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
