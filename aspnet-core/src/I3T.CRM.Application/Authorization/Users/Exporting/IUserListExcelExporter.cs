using System.Collections.Generic;
using I3T.CRM.Authorization.Users.Dto;
using I3T.CRM.Dto;

namespace I3T.CRM.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}