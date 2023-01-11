using Abp.Modules;
using Abp.Reflection.Extensions;

namespace I3T.CRM
{
    public class CRMClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMClientModule).GetAssembly());
        }
    }
}
