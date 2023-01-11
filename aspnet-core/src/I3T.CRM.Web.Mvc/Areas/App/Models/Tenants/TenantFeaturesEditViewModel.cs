using Abp.AutoMapper;
using I3T.CRM.MultiTenancy;
using I3T.CRM.MultiTenancy.Dto;
using I3T.CRM.Web.Areas.App.Models.Common;

namespace I3T.CRM.Web.Areas.App.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}