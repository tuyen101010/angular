using Abp.Application.Services;
using Abp.Application.Services.Dto;
using I3T.CRM.Authorization.Permissions.Dto;

namespace I3T.CRM.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
