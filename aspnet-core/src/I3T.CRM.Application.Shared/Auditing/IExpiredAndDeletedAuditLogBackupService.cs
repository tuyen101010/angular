using System.Collections.Generic;
using Abp.Auditing;

namespace I3T.CRM.Auditing
{
    public interface IExpiredAndDeletedAuditLogBackupService
    {
        bool CanBackup();
        
        void Backup(List<AuditLog> auditLogs);
    }
}