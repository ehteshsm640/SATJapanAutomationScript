using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.DeactivateAccount
{
    public partial class DeactivateAccountPage:BasePage
    {
        public DeactivateAccountPage(AndroidDriver driver) : base(driver) { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By ManageYourAccountMenu => By.XPath("//android.widget.TextView[@text=\"Manage Your Account\"]");
        public By DeactivateAccountMenu => By.XPath("//android.widget.TextView[@text=\"Deactivate Account\"]");
        public By ExplainReason => By.XPath("//android.widget.EditText[@text=\"I want to\"]");
        public By DeleteMyAccount => By.XPath("//android.widget.TextView[@text=\"Delete My Account\"]");
        public By ConfirmButton => By.XPath("//android.widget.TextView[@text=\"Confirm\"]");
        public By CancelButton => By.XPath("//android.widget.TextView[@text=\"Cancel\"]");
        public By ValidateText => By.XPath("//android.widget.TextView[@text=\"Log in or Sign Up\"]");
    }
}
