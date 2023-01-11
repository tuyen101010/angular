using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using I3T.CRM.Authorization.Permissions.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
