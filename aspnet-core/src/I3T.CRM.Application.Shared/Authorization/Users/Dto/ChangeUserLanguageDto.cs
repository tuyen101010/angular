using System.ComponentModel.DataAnnotations;

namespace I3T.CRM.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
