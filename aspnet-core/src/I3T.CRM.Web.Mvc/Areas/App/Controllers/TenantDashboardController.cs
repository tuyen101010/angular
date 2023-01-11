using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using I3T.CRM.Authorization;
using I3T.CRM.DashboardCustomization;
using System.Threading.Tasks;
using I3T.CRM.Web.Areas.App.Startup;

namespace I3T.CRM.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(CRMDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}