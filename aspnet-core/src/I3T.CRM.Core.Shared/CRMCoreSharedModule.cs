using Abp.Modules;
using Abp.Reflection.Extensions;

namespace I3T.CRM
{
    public class CRMCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMCoreSharedModule).GetAssembly());
        }
    }
}