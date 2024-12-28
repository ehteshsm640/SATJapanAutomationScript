using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Pages.Base;

namespace SATJapanMobApplication.Pages.LandingHomePage
{
    public class LandingHomePage :BasePage
    {
        //private AndroidDriver driver;

        public LandingHomePage(AndroidDriver driver) : base(driver)
        {
           // this.driver = driver;
        }


        //IWebElement Home => driver.FindElement(MobileBy.AccessibilityId("Home"));
        public By HomeElement => MobileBy.AccessibilityId("Home");
        
        public bool ValidateHomePage()
        {
           ApplyWait(HomeElement);
           IWebElement Home= driver.FindElement(HomeElement);

            bool result = false;
            if (Home == null)
            {
                ReportHelper.LogFail("FailingValidatingHomePage");
                Assert.Fail();
                return result;
            }
            else
            {

                ReportHelper.LogStep("LandingOnHomePage");
                return !result;
            }
        }
    }
}
