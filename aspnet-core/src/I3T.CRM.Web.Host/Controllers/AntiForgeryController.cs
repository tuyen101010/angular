using Microsoft.AspNetCore.Antiforgery;

namespace I3T.CRM.Web.Controllers
{
    public class AntiForgeryController : CRMControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
