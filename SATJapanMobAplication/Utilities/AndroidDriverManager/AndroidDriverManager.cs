using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATJapanMobApplication.Configuration;

namespace SATJapanMobApplication.Utilities.AndroidDriverManager
{
    public static class AndroidDriverManager
    {

        public static AndroidDriver driver;

        public static AndroidDriver InitializeDriver()
        {
            if (driver == null)
            {
                var ApplicationConfig = ConfigManager.LoadApplicationConfigSetting();

                // Parse the Appium host and setup driver options

                var serverUri = new Uri(ApplicationConfig.AppiumHost);
                var driverOptions = new AppiumOptions
                {
                    AutomationName = AutomationName.AndroidUIAutomator2,
                    PlatformName = ApplicationConfig.PlatformName,
                    DeviceName = ApplicationConfig.DeviceName
                };
                driverOptions.AddAdditionalAppiumOption("udid", ApplicationConfig.udid);
                driverOptions.AddAdditionalAppiumOption("appPackage", ApplicationConfig.AppPackage);
                driverOptions.AddAdditionalAppiumOption("appActivity", ApplicationConfig.AppActivity);
                driverOptions.AddAdditionalAppiumOption("noReset", ApplicationConfig.NoReset);
                driverOptions.AddAdditionalAppiumOption("ignoreHiddenApiPolicyError", true);

                driver = new AndroidDriver(serverUri, driverOptions, TimeSpan.FromSeconds(180));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //ReportHelper.LogStep("Driver initialized.");
            }
            return driver;
        }
        public static void LaunchApplication()
        {
           driver.StartActivity("com.satjapan.mobile", ".MainActivity");

           
        }
        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}
