using Abp.AspNetCore.Mvc.Views;

namespace I3T.CRM.Web.Views
{
    public abstract class CRMRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected CRMRazorPage()
        {
            LocalizationSourceName = CRMConsts.LocalizationSourceName;
        }
    }
}
