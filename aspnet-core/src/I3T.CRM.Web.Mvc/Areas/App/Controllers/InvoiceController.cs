using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using I3T.CRM.MultiTenancy.Accounting;
using I3T.CRM.Web.Areas.App.Models.Accounting;
using I3T.CRM.Web.Controllers;

namespace I3T.CRM.Web.Areas.App.Controllers
{
    [Area("App")]
    public class InvoiceController : CRMControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}