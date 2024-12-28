using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATJapanMobApplication.Configuration;

namespace SATJapanMobApplication.Pages.Base
{
    public abstract partial class BasePage
    {
        public AndroidDriver driver;
        protected WebDriverWait wait;

        public BasePage(AndroidDriver driver)
        {
            this.driver = driver;
        }

        public void ApplyWait(By element)
        {
                ApplyImplicitWait();
                if (!IsElementAppears(element))
                {
                    ApplyExplicitWait(element);

                }

            

        }
       
    
        public bool IsElementAppears(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ApplyImplicitWait()
        {
            var config = ConfigManager.LoadAutomationConfigSetting();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Convert.ToInt32(config.ImplicitWait));
        }

        // Method to apply explicit wait for an element
        public IWebElement ApplyExplicitWait(By element)
        {
            var config = ConfigManager.LoadAutomationConfigSetting();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Convert.ToInt32(config.ExplicitWait)));
            return wait.Until(driver => driver.FindElement(element).Displayed ? driver.FindElement(element) : null);
        }
        public IWebElement WaitForElement(By elementLocator)
        {
            return wait.Until(driver =>
            {
                var element = driver.FindElement(elementLocator);
                return (element.Displayed && element.Enabled) ? element : null;
            });



        }

    }
}
