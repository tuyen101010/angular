using System.Threading.Tasks;
using Abp.Dependency;

namespace I3T.CRM.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}