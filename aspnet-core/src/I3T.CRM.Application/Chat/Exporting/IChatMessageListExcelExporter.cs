using System.Collections.Generic;
using Abp;
using I3T.CRM.Chat.Dto;
using I3T.CRM.Dto;

namespace I3T.CRM.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
