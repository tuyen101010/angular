using Abp.Domain.Services;

namespace I3T.CRM
{
    public abstract class CRMDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CRMDomainServiceBase()
        {
            LocalizationSourceName = CRMConsts.LocalizationSourceName;
        }
    }
}
