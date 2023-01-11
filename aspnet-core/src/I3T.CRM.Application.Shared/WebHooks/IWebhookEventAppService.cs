using System.Threading.Tasks;
using Abp.Webhooks;

namespace I3T.CRM.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
