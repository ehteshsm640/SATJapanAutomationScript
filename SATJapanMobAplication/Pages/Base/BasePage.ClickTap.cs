using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Base
{
    public abstract partial class BasePage
    {
        public void Click(By element)
        {
           
                ApplyWait(element);
                IWebElement clickableElement = driver.FindElement(element);
                clickableElement.Click();

                // Log success
                ReportHelper.LogStep($"Clicked on element located by {element}");
            
        }
        public void Click(By element,string elementName)
        {

            ApplyWait(element);
            IWebElement clickableElement = driver.FindElement(element);
            clickableElement.Click();

            // Log success
            ReportHelper.LogStep($"Clicked on element located by {elementName}");

        }

        public void Click(IWebElement element)
        {
            try
            {

                ApplyImplicitWait();
                element.Click();

                // Log success
                ReportHelper.LogStep($"Clicked on element located by {element}");
            }
            catch (Exception ex)
            {
                // Log failure
                ReportHelper.LogFail($"Failed to click on element located by {element}. Error: {ex.Message}");
            }
        }
        public void LongTap(By element)
        {
            try
            {
                ApplyWait(element);
                IWebElement elementToTap = driver.FindElement(element);
                var touchAction = new TouchAction(driver);
                touchAction.LongPress(elementToTap).Release().Perform();

                // Log success
                ReportHelper.LogStep($"Long tap performed on element located by {element}");
            }
            catch (Exception ex)
            {
                // Log failure
                ReportHelper.LogFail($"Failed to long tap on element located by {element}. Error: {ex.Message}");
            }
        }
        public void LongPressElement(By element)
        {
            try
            {
                IWebElement longPressElement = driver.FindElement(element);
                var action = new Actions(driver);
                action.ClickAndHold(longPressElement).Perform();
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Failed to long press element: {ex.Message}");
            }
        }


    }
}
