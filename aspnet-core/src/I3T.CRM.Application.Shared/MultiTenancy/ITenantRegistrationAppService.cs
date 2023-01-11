using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.Editions.Dto;
using I3T.CRM.MultiTenancy.Dto;

namespace I3T.CRM.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}