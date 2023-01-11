using System.Collections.Generic;
using I3T.CRM.Caching.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}