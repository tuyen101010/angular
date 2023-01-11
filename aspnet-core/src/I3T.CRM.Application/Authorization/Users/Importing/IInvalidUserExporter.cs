using System.Collections.Generic;
using I3T.CRM.Authorization.Users.Importing.Dto;
using I3T.CRM.Dto;

namespace I3T.CRM.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
