using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using I3T.CRM.Web.Areas.App.Models.Layout;
using I3T.CRM.Web.Views;

namespace I3T.CRM.Web.Areas.App.Views.Shared.Components.AppChatToggler
{
    public class AppChatTogglerViewComponent : CRMViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
