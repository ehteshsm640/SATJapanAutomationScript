using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Language
{
    public partial class LanguagePage:BasePage
    {
        public LanguagePage(AndroidDriver driver) : base(driver) { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By LanguageMenu => By.XPath($"//android.widget.TextView[@text=\"{CurrentLanguageData}\"]");
        public By SelectLanguage => By.XPath($"//android.widget.TextView[@text=\"{LanguageData}\"]");
    }
}
