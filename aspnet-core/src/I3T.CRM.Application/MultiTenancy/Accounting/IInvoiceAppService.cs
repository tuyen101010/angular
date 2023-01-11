using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using I3T.CRM.MultiTenancy.Accounting.Dto;

namespace I3T.CRM.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
