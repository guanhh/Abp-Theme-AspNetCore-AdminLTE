using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;

namespace AdminLTE.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.ToolBar
{
    public class ToolBarViewComponent : AbpViewComponent
    {
        private readonly IToolbarManager _toolbarManager;

        public ToolBarViewComponent(IToolbarManager toolbarManager)
        {
            _toolbarManager = toolbarManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var toolbar = await _toolbarManager.GetAsync(StandardToolbars.Main);
            return View("~/Themes/Basic/Components/Toolbar/Default.cshtml", toolbar);
        }
    }
}
