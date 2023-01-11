using System.Collections.Generic;
using I3T.CRM.Auditing.Dto;
using I3T.CRM.Dto;

namespace I3T.CRM.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
