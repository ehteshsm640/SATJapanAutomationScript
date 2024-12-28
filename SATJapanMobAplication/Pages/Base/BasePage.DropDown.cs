using OpenQA.Selenium;
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

        // Function to select an option from a dropdown by visible text
        public void SelectDropdownOptionByText(By dropdownElement, string optionText)
        {
            if (!string.IsNullOrEmpty(optionText))
            {
                try
                {
                    ApplyWait(dropdownElement);
                    // Click the dropdown to expand options
                    IWebElement dropdown = driver.FindElement(dropdownElement);

                    dropdown.Click();

                    // XPath to find the option based on the visible text
                    string optionXPath = $"//android.widget.TextView[@text='{optionText}']";
                    IWebElement option = driver.FindElement(By.XPath(optionXPath));

                    // Click the option
                    option.Click();

                    // Logging the action
                    ReportHelper.LogStep($"Selected '{optionText}' from dropdown.");
                }
                catch (Exception ex)
                {
                    ReportHelper.LogFail($"Failed to select '{optionText}' from dropdown. Error: {ex.Message}");
                }
            }
        }

        // Function to select an option from a dropdown by index
        public void SelectDropdownOptionByIndex(By dropdownElement, int index)
        {
            if (index != 0)
            {
                try
                {
                    ApplyWait(dropdownElement);
                    // Click the dropdown to expand options
                    IWebElement dropdown = driver.FindElement(dropdownElement);
                    dropdown.Click();

                    // XPath to find the option based on the index
                    string optionXPath = $"//android.widget.TextView[{index}]";
                    IWebElement option = driver.FindElement(By.XPath(optionXPath));

                    // Click the option
                    option.Click();

                    // Logging the action
                    ReportHelper.LogStep($"Selected option at index {index} from dropdown.");
                }
                catch (Exception ex)
                {
                    ReportHelper.LogFail($"Failed to select option at index {index} from dropdown. Error: {ex.Message}");
                }
            }
        }
        public void SelectDropdownOptionByValue(By dropdownElement, string optionValue)
        {
            if (!string.IsNullOrEmpty(optionValue))
            {
                try
                {
                    ApplyWait(dropdownElement);
                    // Click the dropdown to expand options
                    IWebElement dropdown = driver.FindElement(dropdownElement);
                    dropdown.Click();

                    // XPath to find the option based on the value
                    string optionXPath = $"//android.widget.TextView[@value='{optionValue}']";
                    IWebElement option = driver.FindElement(By.XPath(optionXPath));

                    // Click the option
                    option.Click();

                    // Logging the action
                    ReportHelper.LogStep($"Selected option with value '{optionValue}' from dropdown.");
                }
                catch (Exception ex)
                {
                    ReportHelper.LogFail($"Failed to select option with value '{optionValue}' from dropdown. Error: {ex.Message}");
                }
            }
        }
    }
}
