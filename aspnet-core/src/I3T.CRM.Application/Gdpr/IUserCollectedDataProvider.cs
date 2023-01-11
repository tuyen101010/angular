using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using I3T.CRM.Dto;

namespace I3T.CRM.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
