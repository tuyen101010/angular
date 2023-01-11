using CRM.EntityFrameworkCore.Repositories;
using I3T.CRM.Common.Caches;
using System.Data;

namespace I3T.CRM.SqlObject
{
    public class LoadDataToCache : ILoadDataToCache
    {
        private readonly IRepositorySqlServerContext _MsSqlServer;

        public LoadDataToCache(IRepositorySqlServerContext MsSqlServer)
        {
            _MsSqlServer = MsSqlServer;
        }

        public async Task Instance()
        {
            await SysTenantCustomPages.LoadToCache(_MsSqlServer);
        }

    }
}
