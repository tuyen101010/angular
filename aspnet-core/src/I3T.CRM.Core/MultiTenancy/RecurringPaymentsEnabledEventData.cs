using Abp.Events.Bus;

namespace I3T.CRM.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}