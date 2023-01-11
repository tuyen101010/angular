using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using I3T.CRM.Configure;
using I3T.CRM.Startup;
using I3T.CRM.Test.Base;

namespace I3T.CRM.GraphQL.Tests
{
    [DependsOn(
        typeof(CRMGraphQLModule),
        typeof(CRMTestBaseModule))]
    public class CRMGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMGraphQLTestModule).GetAssembly());
        }
    }
}