using System.Collections.Generic;
using Abp.Localization;
using I3T.CRM.Install.Dto;

namespace I3T.CRM.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
