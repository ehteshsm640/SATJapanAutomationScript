using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Pages.Base;
using SATJapanMobApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using SATJapanMobApplication.Utilities.Helper;
using OpenQA.Selenium.BiDi.Modules.Script;

namespace SATJapanMobApplication.Pages.Search
{
    public class SearchPage : BasePage
    {
       public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string SearchSheetname= "Search";
        ExcelHelper excel;
        string StockIDData;
      
        
        public SearchPage(AndroidDriver driver):base(driver)
        {
              
        }


        public void LoadData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), SearchSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);
            StockIDData = excel.ReadDataFromExcel(nameof(StockIDData));
            ReportHelper.LogStep("DataLoaded");
        }
      
        //Elements
        public By SearchMenu => MobileBy.AccessibilityId("Search");
        //android.view.ViewGroup[contains(@content-desc, "Stock ID: sat-61100952")]
        //string StockGroup = $"//android.view.ViewGroup[contains(@content-desc, \"Stock ID: {StockIDData}\")]";
        //string StockIDElment = $"//android.widget.TextView[@text=\"Stock ID: {StockIDData}\"]";
        public By Test => By.XPath($"//android.view.ViewGroup[contains(@content-desc, \"Stock ID: sat-{StockIDData}\")]");
        IWebElement StockGroup => driver.FindElement(By.XPath($"//android.view.ViewGroup[contains(@content-desc, \"Stock ID: sat-{StockIDData}\")]"));
        IWebElement StockIDElment => driver.FindElement(By.XPath($"//android.widget.TextView[@text=\"Stock ID: sat-{StockIDData}\"]"));
        IWebElement SortButton => driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Sort\"]"));
        IWebElement SortPriceLowToHigh => driver.FindElement(MobileBy.AccessibilityId("Price low to high"));
        IWebElement SortPriceHighToLow => driver.FindElement(MobileBy.AccessibilityId("Price high to low"));
        IWebElement SortMileageLowToHigh => driver.FindElement(MobileBy.AccessibilityId("Mileage low to high"));

        public void ClickSearchMenu()
        {
            Click(SearchMenu);
            Thread.Sleep(1000);

        }

        public void ScrollAndClickElement()
        {
            bool isElementFound = false;
            int maxScrollAttempts = 10; // Add a limit to prevent infinite scrolling in case of issues
            int scrollAttempts = 0;

            while (!isElementFound && scrollAttempts < maxScrollAttempts)
            {
                // Create UiScrollable object to scroll through the list
                string uiScrollable = "new UiScrollable(new UiSelector().scrollable(true).className(\"android.widget.ScrollView\"))" +
                             $".scrollIntoView(new UiSelector().descriptionContains(\"Stock ID: sat-{StockIDData}\"));";

            
                try
                {

                    // Perform the scrolling action
                    driver.FindElement(MobileBy.AndroidUIAutomator(uiScrollable));  
                    ReportHelper.LogStep($"Scroll to element Stock ID  Sat-{StockIDData}");

                    // Find the ViewGroup by its content-desc and click the element inside

                    if (StockGroup.Displayed)
                    {
                        // Click the TextView element that matches the Stock ID inside the ViewGroup

                        //if (StockIDElment.Displayed)
                        //{
                            Click(StockGroup);
                            break;
                        
                    }
                }
                catch (Exception) {
                    ReportHelper.LogStep($"Element Stock ID: sat-{StockIDData} not found. Scrolling again...");
                    scrollAttempts++;
                }
              
            }
           
        }

        //public void ScrollAndClickElement()
        //{
        //    try
        //    {
        //        bool isElementFound = false;
        //        int maxScrollAttempts = 10; // Add a limit to prevent infinite scrolling in case of issues
        //        int scrollAttempts = 0;

        //        while (!isElementFound && scrollAttempts < maxScrollAttempts)
        //        {
        //             Create UiScrollable object to scroll through the list
        //            string uiScrollable = "new UiScrollable(new UiSelector().scrollable(true).className(\"android.widget.ScrollView\"))" +
        //                                  $".scrollIntoView(new UiSelector().descriptionContains(\"Stock ID: sat-{StockIDData}\"));";

        //            try
        //            {
        //                 Try to find the element by scrolling
        //                driver.FindElement(MobileBy.AndroidUIAutomator(uiScrollable));
        //                ReportHelper.LogStep($"Scrolled to element Stock ID: sat-{StockIDData}");
        //                isElementFound = true;
        //            }
        //            catch (NoSuchElementException)
        //            {
        //                 Handle the case where the element is not found in this scroll attempt
        //                ReportHelper.LogStep($"Element Stock ID: sat-{StockIDData} not found. Scrolling again...");
        //                scrollAttempts++;
        //            }
        //        }

        //        if (!isElementFound)
        //        {
        //            throw new Exception($"Failed to find the element Stock ID: sat-{StockIDData} after {scrollAttempts} scroll attempts.");
        //        }

        //         Once the element is found, try to click it
        //        if (StockGroup.Displayed)
        //        {
        //             Click the TextView element that matches the Stock ID inside the ViewGroup
        //            if (StockIDElment.Displayed)
        //            {
        //                Click(StockGroup);
        //                ReportHelper.LogStep($"Clicked on the Stock ID: sat-{StockIDData}");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ReportHelper.LogFail($"Failed to scroll and click element with Stock ID: sat-{StockIDData}. Error: {ex.Message}");
        //    }
        //}

    }
}
