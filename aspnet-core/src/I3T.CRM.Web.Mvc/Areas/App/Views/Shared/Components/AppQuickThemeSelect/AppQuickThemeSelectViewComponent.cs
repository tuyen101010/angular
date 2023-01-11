using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using I3T.CRM.Web.Areas.App.Models.Layout;
using I3T.CRM.Web.Views;

namespace I3T.CRM.Web.Areas.App.Views.Shared.Components.
    AppQuickThemeSelect
{
    public class AppQuickThemeSelectViewComponent : CRMViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-interface-7 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new QuickThemeSelectionViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
