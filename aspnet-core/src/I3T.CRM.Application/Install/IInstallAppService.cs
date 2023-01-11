using System.Threading.Tasks;
using Abp.Application.Services;
using I3T.CRM.Install.Dto;

namespace I3T.CRM.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}