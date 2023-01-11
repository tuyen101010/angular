using System.Collections.Generic;
using MvvmHelpers;
using I3T.CRM.Models.NavigationMenu;

namespace I3T.CRM.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}