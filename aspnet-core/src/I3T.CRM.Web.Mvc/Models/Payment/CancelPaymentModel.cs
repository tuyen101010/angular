using I3T.CRM.MultiTenancy.Payments;

namespace I3T.CRM.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}