using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.Configuration.Host.Dto;

namespace I3T.CRM.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
