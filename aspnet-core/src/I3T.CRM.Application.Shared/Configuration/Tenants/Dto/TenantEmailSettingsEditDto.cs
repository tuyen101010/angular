using Abp.Auditing;
using I3T.CRM.Configuration.Dto;

namespace I3T.CRM.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}