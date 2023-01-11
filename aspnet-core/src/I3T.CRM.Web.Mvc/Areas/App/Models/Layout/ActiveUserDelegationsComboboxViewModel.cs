using System.Collections.Generic;
using I3T.CRM.Authorization.Delegation;
using I3T.CRM.Authorization.Users.Delegation.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
