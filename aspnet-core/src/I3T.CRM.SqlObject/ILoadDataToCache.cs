using Abp.Domain.Repositories;

namespace I3T.CRM.SqlObject
{
    public interface ILoadDataToCache : IRepository
    {
        Task Instance();
    }
}
