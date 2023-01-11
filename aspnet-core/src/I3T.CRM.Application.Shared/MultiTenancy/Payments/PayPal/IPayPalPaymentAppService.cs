using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.MultiTenancy.Payments.PayPal.Dto;

namespace I3T.CRM.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
