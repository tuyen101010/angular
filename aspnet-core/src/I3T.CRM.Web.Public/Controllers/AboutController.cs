using Microsoft.AspNetCore.Mvc;
using I3T.CRM.Web.Controllers;

namespace I3T.CRM.Web.Public.Controllers
{
    public class AboutController : CRMControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}