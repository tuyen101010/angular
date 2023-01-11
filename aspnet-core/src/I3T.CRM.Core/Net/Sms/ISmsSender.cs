using System.Threading.Tasks;

namespace I3T.CRM.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}