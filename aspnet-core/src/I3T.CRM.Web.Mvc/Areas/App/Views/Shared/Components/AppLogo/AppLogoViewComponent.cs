using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using I3T.CRM.Web.Areas.App.Models.Layout;
using I3T.CRM.Web.Session;
using I3T.CRM.Web.Views;

namespace I3T.CRM.Web.Areas.App.Views.Shared.Components.AppLogo
{
    public class AppLogoViewComponent : CRMViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
