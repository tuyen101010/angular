using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using I3T.CRM.Authorization;
using I3T.CRM.Notifications;
using I3T.CRM.Notifications.Dto;
using I3T.CRM.Web.Areas.App.Models.Notifications;
using I3T.CRM.Web.Controllers;

namespace I3T.CRM.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class NotificationsController : CRMControllerBase
    {
        private readonly INotificationAppService _notificationAppService;

        public NotificationsController(INotificationAppService notificationAppService)
        {
            _notificationAppService = notificationAppService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<PartialViewResult> SettingsModal()
        {
            var notificationSettings = await _notificationAppService.GetNotificationSettings();
            return PartialView("_SettingsModal", notificationSettings);
        }
        
        [AbpMvcAuthorize(AppPermissions.Pages_Administration_MassNotification_Create)]
        public async Task<PartialViewResult> CreateMassNotificationModal()
        {
            var viewModel = new CreateMassNotificationViewModel
            {
                TargetNotifiers = _notificationAppService.GetAllNotifiers()
            };

            return PartialView("_CreateMassNotificationModal", viewModel);
        }
        
        [AbpMvcAuthorize(AppPermissions.Pages_Administration_MassNotification)]
        public PartialViewResult UserLookupTableModal()
        {
            return PartialView("_UserLookupTableModal");
        }
        
        [AbpMvcAuthorize(AppPermissions.Pages_Administration_MassNotification)]
        public PartialViewResult OrganizationUnitLookupTableModal()
        {
            return PartialView("_OrganizationUnitLookupTableModal");
        }
        
                
        [AbpMvcAuthorize(AppPermissions.Pages_Administration_MassNotification)]
        public ActionResult MassNotifications()
        {
            return View();
        }
    }
}