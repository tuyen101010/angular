using System.Collections.Generic;
using Abp.Application.Services.Dto;
using I3T.CRM.Editions.Dto;

namespace I3T.CRM.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}