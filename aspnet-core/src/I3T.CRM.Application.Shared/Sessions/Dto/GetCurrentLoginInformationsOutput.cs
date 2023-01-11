using I3T.CRM.Common.Dtos;
using I3T.CRM.UiCustomization.Dto;
using System.Collections.Generic;

namespace I3T.CRM.Sessions.Dto
{
    public class GetCurrentLoginInformationsOutput
    {
        public UserLoginInfoDto User { get; set; }

        public UserLoginInfoDto ImpersonatorUser { get; set; }

        public TenantLoginInfoDto Tenant { get; set; }

        public TenantLoginInfoDto ImpersonatorTenant { get; set; }

        public ApplicationInfoDto Application { get; set; }

        public UiCustomizationSettingsDto Theme { get; set; }

        public List<TenantCustomPageItemDto> TenantCustomPages { get; set; }
    }
}