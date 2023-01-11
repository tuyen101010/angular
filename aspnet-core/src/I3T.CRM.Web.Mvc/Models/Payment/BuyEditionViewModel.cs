using System.Collections.Generic;
using I3T.CRM.Editions;
using I3T.CRM.Editions.Dto;
using I3T.CRM.MultiTenancy.Payments;
using I3T.CRM.MultiTenancy.Payments.Dto;

namespace I3T.CRM.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
