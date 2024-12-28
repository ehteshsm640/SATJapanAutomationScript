using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Language
{
    public partial class LanguagePage
    {
        public void FillLanguagePage()
        {
            Click(Menu,nameof(Menu));
            Click(LanguageMenu,nameof(LanguageMenu));
            Click(SelectLanguage,nameof(SelectLanguage));
            
        }
        }
}
