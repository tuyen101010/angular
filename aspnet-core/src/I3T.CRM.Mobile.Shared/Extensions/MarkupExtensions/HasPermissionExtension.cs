using System;
using I3T.CRM.Core;
using I3T.CRM.Core.Dependency;
using I3T.CRM.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I3T.CRM.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}