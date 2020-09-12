using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace AdminLTE.Abp.AspNetCore.Mvc.UI.Theme.Basic.Bundling
{
    public class BasicThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            //context.Files.Add("/themes/js/bootstrap/js/bootstrap.bundle.min.js");
            context.Files.Add("/themes/js/adminlte.min.js");
            context.Files.Add("/themes/js/demo.js");
        }
    }
}
