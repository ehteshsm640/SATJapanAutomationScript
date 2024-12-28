using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Currency
{
    public partial class CurrencyPage:BasePage
    {
        public CurrencyPage(AndroidDriver driver) : base(driver) { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By CurrencyMenu => By.XPath("//android.widget.TextView[@text=\"Currency\"]");
        public By SearchCurrency => By.XPath("//android.widget.EditText[@text=\"Search Currency\"]");
        public By SelectCurrency => By.XPath($"//android.widget.TextView[@text=\"{SearchCurrencyData}\"]");
    }
}
