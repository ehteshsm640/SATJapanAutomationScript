using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

using SATJapanWebApplication.Utilities;
using SATJapanWebApplication.Pages.Base;
using SATJapanWebApplication.Tests;
using SATJapanWebApplication.Utilities.Browser;

namespace SATJapanWebApplication.Pages.LandingHomePage
{
    [TestClass]
    public class Test :BaseTest
    {
        //private AndroidDriver driver
    
        [TestMethod]
        public void Test1()
        { 
            var driver = DriverManager.GetDriver();
            IWebElement HomeLogo = driver.FindElement(By.XPath("//img[@src='https://satjapan.com/assets/images/logo/logosv.svg']"));


            ReportHelper.CreateTest("Test");

        }
    }
}
