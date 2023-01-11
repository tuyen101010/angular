using Abp.AutoMapper;
using I3T.CRM.Authorization.Users;
using I3T.CRM.Authorization.Users.Dto;
using I3T.CRM.Web.Areas.App.Models.Common;

namespace I3T.CRM.Web.Areas.App.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}