using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using I3T.CRM.Queries.Container;
using System;

namespace I3T.CRM.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}