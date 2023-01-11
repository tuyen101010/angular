namespace I3T.CRM.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}