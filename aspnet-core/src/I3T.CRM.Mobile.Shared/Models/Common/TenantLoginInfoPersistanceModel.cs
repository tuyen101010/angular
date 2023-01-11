using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using I3T.CRM.Sessions.Dto;

namespace I3T.CRM.Models.Common
{
    [AutoMapFrom(typeof(TenantLoginInfoDto)),
     AutoMapTo(typeof(TenantLoginInfoDto))]
    public class TenantLoginInfoPersistanceModel : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}