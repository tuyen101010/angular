using I3T.CRM.Editions;
using I3T.CRM.Editions.Dto;
using I3T.CRM.MultiTenancy.Payments;
using I3T.CRM.Security;
using I3T.CRM.MultiTenancy.Payments.Dto;

namespace I3T.CRM.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
