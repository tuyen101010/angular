using System.Collections.Generic;
using I3T.CRM.Editions.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}