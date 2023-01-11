using Abp.AspNetCore.Mvc.ViewComponents;

namespace I3T.CRM.Web.Views
{
    public abstract class CRMViewComponent : AbpViewComponent
    {
        protected CRMViewComponent()
        {
            LocalizationSourceName = CRMConsts.LocalizationSourceName;
        }
    }
}