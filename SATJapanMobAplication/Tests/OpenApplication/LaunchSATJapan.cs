using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Runtime.CompilerServices;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Pages.LandingHomePage;
using SATJapanMobApplication.Utilities;

namespace SATJapanMobApplication.Tests.OpenApplication
{

    [TestClass]
    public class LaunchSATJapan:BaseTest
      {
        

        [TestMethod]
        public void LunchSATJapan()
        {
           
           var LandingHomePage = new LandingHomePage(AndroidDriverManager.driver);
            ReportHelper.CreateTest(nameof(LandingHomePage));
            try
            {
                if (LandingHomePage.ValidateHomePage()) 
                ReportHelper.LogPass(nameof(LandingHomePage)+"Pass");
                else Assert.Fail("Failed");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(LandingHomePage) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                 screenshot.CaptureScreenshot(nameof(LandingHomePage));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }

        }
    }
}