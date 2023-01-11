using System.Collections.Generic;
using I3T.CRM.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace I3T.CRM.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
