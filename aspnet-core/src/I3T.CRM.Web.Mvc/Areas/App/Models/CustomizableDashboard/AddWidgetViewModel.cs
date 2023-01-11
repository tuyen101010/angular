using System.Collections.Generic;
using I3T.CRM.DashboardCustomization.Dto;

namespace I3T.CRM.Web.Areas.App.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
