using Abp.AutoMapper;
using I3T.CRM.MultiTenancy.Dto;

namespace I3T.CRM.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
