using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.MultiTenancy.Payments.Dto;
using I3T.CRM.MultiTenancy.Payments.Stripe.Dto;

namespace I3T.CRM.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}