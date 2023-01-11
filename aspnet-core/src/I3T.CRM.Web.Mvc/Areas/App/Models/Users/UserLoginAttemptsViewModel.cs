using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace I3T.CRM.Web.Areas.App.Models.Users
{
    public class UserLoginAttemptsViewModel
    {
        public List<ComboboxItemDto> LoginAttemptResults { get; set; }
    }
}