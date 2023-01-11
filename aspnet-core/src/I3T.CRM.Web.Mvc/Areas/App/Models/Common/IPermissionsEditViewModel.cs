using System.Collections.Generic;
using I3T.CRM.Authorization.Permissions.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}