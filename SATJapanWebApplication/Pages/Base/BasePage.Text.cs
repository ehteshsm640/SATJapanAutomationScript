using OpenQA.Selenium;
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
        // Function to enter text into a text field
        public void Clear_EnterText(By element, string elementData)
        {
            if (!string.IsNullOrEmpty(elementData)) { 
                try
                {
                    ApplyWait(element);
                    IWebElement textField = driver.FindElement(element);
                    textField.Clear();
                    textField.SendKeys(elementData);
                    ReportHelper.LogStep($"{elementData} value Entered at {element}");
                }
                catch (Exception ex)
                {
                    ReportHelper.LogFail($"Failed to enter {elementData} at {nameof(element)} Error Message : {ex.Message}");
                }
        }
        }

        public void EnterText(By element, string elementData)
        {
            if (!string.IsNullOrEmpty(elementData))
            {
                try
                {
                    ApplyWait(element);
                    IWebElement textField = driver.FindElement(element);
                   
                    textField.SendKeys(elementData);
                    ReportHelper.LogStep($"{elementData} value Entered at {nameof(element)}");
                }
                catch (Exception ex)
                {
                    ReportHelper.LogFail($"Failed to enter {elementData} at {nameof(element)} Error Message : {ex.Message}");
                }
            }
        }
        public void EnterText_PressEnter(By element, string elementData)
        {
            if (!string.IsNullOrEmpty(elementData))
            {
                try
                {
                    ApplyWait(element);
                    IWebElement textField = driver.FindElement(element);
                    textField.SendKeys(elementData);
                    textField.SendKeys(Keys.Enter);
                    ReportHelper.LogStep($"{elementData} value Entered at {nameof(element)}");
                }
                catch (Exception ex)
                {
                    ReportHelper.LogFail($"Failed to enter {elementData} at {nameof(element)} Error Message : {ex.Message}");
                }
            }
        }
        // Function to get text from a text field
        public string GetText(By element)
        {
            try
            {
                WaitForElement(element);
                IWebElement textField = driver.FindElement(element);
                return textField.Text;
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail($"Fiald to Load Text from field {nameof(element)}");
                return null;
            }
        }
    }
}
