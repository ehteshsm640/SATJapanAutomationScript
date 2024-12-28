using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.SignOut
{
    public partial class SignOutPage:BasePage
    {
        public SignOutPage(AndroidDriver driver) : base(driver) { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By ManageYourAccountMenu => By.XPath("//android.widget.TextView[@text=\"Manage Your Account\"]");
        public By SignOutMenu => By.XPath("//android.widget.TextView[@text=\"Sign Out\"]");
        public By SignOutButton => By.XPath("//android.view.ViewGroup[@content-desc=\"Logout\"]");
        public By CencelButton => By.XPath("//android.view.ViewGroup[@content-desc=\"Cancel\"]");
    }
}
