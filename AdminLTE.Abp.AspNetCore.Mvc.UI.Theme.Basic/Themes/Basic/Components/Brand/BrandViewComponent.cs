using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;

namespace AdminLTE.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Brand
{
    public class BrandViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Basic/Components/Brand/Default.cshtml");
        }
    }
}
