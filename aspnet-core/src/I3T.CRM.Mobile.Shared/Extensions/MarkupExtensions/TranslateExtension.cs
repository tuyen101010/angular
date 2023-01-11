using System;
using I3T.CRM.Core;
using I3T.CRM.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace I3T.CRM.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return Text;
            }

            return L.Localize(Text);
        }
    }
}