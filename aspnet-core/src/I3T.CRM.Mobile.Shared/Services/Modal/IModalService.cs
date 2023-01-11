using System.Threading.Tasks;
using I3T.CRM.Views;
using Xamarin.Forms;

namespace I3T.CRM.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
