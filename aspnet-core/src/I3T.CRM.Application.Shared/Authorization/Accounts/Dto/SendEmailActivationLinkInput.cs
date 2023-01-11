using System.ComponentModel.DataAnnotations;

namespace I3T.CRM.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}