using Abp.Application.Services;
using I3T.CRM.Dto;
using I3T.CRM.Logging.Dto;

namespace I3T.CRM.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
