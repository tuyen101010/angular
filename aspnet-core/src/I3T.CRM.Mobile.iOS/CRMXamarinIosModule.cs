using Abp.Modules;
using Abp.Reflection.Extensions;

namespace I3T.CRM
{
    [DependsOn(typeof(CRMXamarinSharedModule))]
    public class CRMXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMXamarinIosModule).GetAssembly());
        }
    }
}