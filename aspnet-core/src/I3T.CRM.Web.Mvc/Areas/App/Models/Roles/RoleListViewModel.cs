using System.Collections.Generic;
using Abp.Application.Services.Dto;
using I3T.CRM.Authorization.Permissions.Dto;
using I3T.CRM.Web.Areas.App.Models.Common;

namespace I3T.CRM.Web.Areas.App.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}