using System.Threading.Tasks;
using I3T.CRM.Security.Recaptcha;

namespace I3T.CRM.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
