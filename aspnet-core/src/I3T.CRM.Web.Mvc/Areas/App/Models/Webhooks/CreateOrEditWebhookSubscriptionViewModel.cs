using Abp.Application.Services.Dto;
using Abp.Webhooks;
using I3T.CRM.WebHooks.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
