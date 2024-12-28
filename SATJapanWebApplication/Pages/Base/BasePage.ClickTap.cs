using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SATJapanWebApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanWebApplication.Pages.Base
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
       
       


    }
}
