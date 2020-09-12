using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Localization;

namespace AdminLTE.Abp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.ToolBar.LanguageSwitch
{
    public class LanguageSwitchViewComponentModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public List<LanguageInfo> OtherLanguages { get; set; }
    }
}
