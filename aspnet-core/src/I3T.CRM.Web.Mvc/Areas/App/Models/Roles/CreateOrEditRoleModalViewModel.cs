using Abp.AutoMapper;
using I3T.CRM.Authorization.Roles.Dto;
using I3T.CRM.Web.Areas.App.Models.Common;

namespace I3T.CRM.Web.Areas.App.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}