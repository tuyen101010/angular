using Microsoft.Extensions.Configuration;

namespace I3T.CRM.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
