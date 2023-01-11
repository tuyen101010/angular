using System.Collections.Generic;
using I3T.CRM.DynamicEntityProperties.Dto;

namespace I3T.CRM.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
