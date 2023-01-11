using Abp.AutoMapper;
using I3T.CRM.Organizations.Dto;

namespace I3T.CRM.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}