using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.ConsigneeInformation
{
    public partial class ConsigneeInformationPage:BasePage
    {
        public ConsigneeInformationPage(AndroidDriver driver) : base(driver) { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By ManageYourAccountMenu => By.XPath("//android.widget.TextView[@text=\"Manage Your Account\"]");
        public By ConsigneeInformationMenu => By.XPath("//android.widget.TextView[@text=\"Consignee Information\"]");
        public By Name => By.XPath("//android.widget.EditText[@text=\"Enter your name\"]");
        public By ContouryCodeButton => By.XPath("//android.widget.TextView[@text=\"🇵🇰\"]");
        public By PhoneContouryCodeSearch => By.XPath("//android.widget.EditText[@resource-id=\"text-input-country-filter\"]");
        public By SelectPhoneContouryCode => By.XPath($"//android.view.ViewGroup[contains(@content-desc,'{PhoneCountryNameSearchData}')]");
        public By PhoneNo => By.XPath("//android.widget.EditText[@text=\"Phone Number\"]");

        public By Country => By.XPath("//android.view.ViewGroup[@content-desc=\"Country\"]");
        public By Search => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By SelectCountryName => By.XPath($"//android.widget.TextView[@text='{CountryNameData}']");
        public By State => By.XPath("//android.widget.EditText[@text=\"Enter your state\"]");
        public By City => By.XPath("//android.widget.EditText[@text=\"Enter your city\"]");
        public By Email => By.XPath("//android.widget.EditText[@text=\"Enter your email\"]");
        public By Address => By.XPath("//android.widget.EditText[@text=\"Enter your address\"]");
        public By UpdateInformationButton => By.XPath("//android.widget.TextView[@text=\"Update Information\"]");
    }   
}
