using System.Collections.Generic;
using Abp.Application.Services.Dto;
using I3T.CRM.Editions.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}