using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.Configuration.Tenants.Dto;

namespace I3T.CRM.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
