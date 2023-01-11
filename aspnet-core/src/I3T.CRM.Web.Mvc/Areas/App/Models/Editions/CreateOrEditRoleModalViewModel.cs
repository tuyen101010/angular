using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using I3T.CRM.Editions.Dto;
using I3T.CRM.Web.Areas.App.Models.Common;

namespace I3T.CRM.Web.Areas.App.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class CreateEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}