using System;
using System.Collections.Generic;
using System.Text;

namespace I3T.CRM.Common.Dtos
{
    public class TenantCustomPageItemDto
    {
        public int? Id { get; set; }
        public int? PageIndex { get; set; }
        public string PageMenuKey { get; set; }
        public string PageTitleKey { get; set; }
    }

    public class TenantCustomPageInputDto
    {
        public int? TenantId { get; set; }
        public List<TenantCustomPageItemDto> Items { get; set; }
    }
}
