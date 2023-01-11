using System.Collections.Generic;
using Abp.Application.Services.Dto;
using I3T.CRM.Configuration.Tenants.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}