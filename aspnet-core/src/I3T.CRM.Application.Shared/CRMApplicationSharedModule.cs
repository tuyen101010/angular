using Abp.Modules;
using Abp.Reflection.Extensions;

namespace I3T.CRM
{
    [DependsOn(typeof(CRMCoreSharedModule))]
    public class CRMApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMApplicationSharedModule).GetAssembly());
        }
    }
}