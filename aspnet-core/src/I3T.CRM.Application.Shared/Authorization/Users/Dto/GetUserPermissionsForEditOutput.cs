using System.Collections.Generic;
using I3T.CRM.Authorization.Permissions.Dto;

namespace I3T.CRM.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}