using System.ComponentModel.DataAnnotations;

namespace I3T.CRM.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}