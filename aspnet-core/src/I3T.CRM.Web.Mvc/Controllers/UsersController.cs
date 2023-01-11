using Abp.AspNetCore.Mvc.Authorization;
using I3T.CRM.Authorization;
using I3T.CRM.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace I3T.CRM.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}