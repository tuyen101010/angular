using I3T.CRM.Editions.Dto;

namespace I3T.CRM.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < CRMConsts.MinimumUpgradePaymentAmount;
        }
    }
}
