using Microsoft.CodeAnalysis.Emit;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interactions;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointerInputDevice = OpenQA.Selenium.Appium.Interactions.PointerInputDevice;

namespace SATJapanMobApplication.Pages.Base
{
    public abstract partial class BasePage
    {
        public void ScrollToElementDown(By element)
        {
            try
            {
                bool elementFound = false;
                while (!elementFound)
                {
                    try
                    {
                        IWebElement scrollElement = driver.FindElement(element);
                        if (scrollElement.Displayed)
                        {
                            elementFound = true;
                            //scrollElement.Click();
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        ScrollDown();
                    }
                }
            }
                
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to scroll and find element: {ex.Message}");
            }
        }
        // Helper function to perform scroll action
        public void ScrollDown()
        {
            var touchAction = new TouchAction(driver);
            var screenSize = driver.Manage().Window.Size;
            int startX = screenSize.Width / 2;
            int startY = (int)(screenSize.Height * 0.8);
            int endY = (int)(screenSize.Height * 0.2);
            touchAction.Press(startX, startY).Wait(2000).MoveTo(startX, endY).Release().Perform();
        }
        public void ScrollFurtherAndClickElement(By elementLocator, int maxScrollAttempts = 10)
        {
            bool isElementFound = false;
            int scrollAttempts = 0;

            while (!isElementFound && scrollAttempts < maxScrollAttempts)
            {
                try
                {
                    // Try to find the element without scrolling first
                    var element = driver.FindElement(elementLocator);

                    if (element.Displayed)
                    {
                        element.Click();
                        isElementFound = true;
                        ReportHelper.LogStep($"Element found and clicked: {elementLocator.ToString()}");
                    }
                }
                catch (Exception)
                {
                    // If element is not found, scroll and try again
                    string uiScrollable = "new UiScrollable(new UiSelector().scrollable(true).className(\"android.widget.ScrollView\"))" +
                                          $".scrollForward();";  // Scroll forward by default

                    try
                    {
                        // Perform the scrolling action
                        driver.FindElement(MobileBy.AndroidUIAutomator(uiScrollable));
                        ReportHelper.LogStep($"Scrolled attempt {scrollAttempts + 1}");
                        scrollAttempts++;
                    }
                    catch (Exception ex)
                    {
                        // If scrolling itself fails, log the issue and exit
                        ReportHelper.LogStep($"Scrolling failed at attempt {scrollAttempts + 1}. Error: {ex.Message}");
                        break;
                    }
                }
            }

            if (!isElementFound)
            {
                throw new NoSuchElementException($"Element could not be found after {maxScrollAttempts} scroll attempts: {elementLocator.ToString()}");
            }
        }
        public void ScrollAndClickElement(By elementLocator, string scrollableClassName = "android.widget.ScrollView", int maxScrollAttempts = 10)
        {
            bool isElementFound = false;
            int scrollAttempts = 0;

            while (!isElementFound && scrollAttempts < maxScrollAttempts)
            {
                try
                {
                    // Create UiScrollable object to scroll through the list and scroll to the element
                    string uiScrollable = $"new UiScrollable(new UiSelector().scrollable(true).className(\"{scrollableClassName}\"))" +
                                          $".scrollIntoView(new UiSelector().resourceIdMatches(\"{elementLocator.ToString().Replace("By.XPath:", "")}\"));";

                    // Perform the scrolling action
                    driver.FindElement(MobileBy.AndroidUIAutomator(uiScrollable));
                    ReportHelper.LogStep($"Scrolled to element using locator: {elementLocator.ToString()}");

                    // Try to find the element after scrolling
                    var element = driver.FindElement(elementLocator);

                    if (element.Displayed)
                    {
                        element.Click();
                        isElementFound = true;
                        ReportHelper.LogStep($"Element found and clicked: {elementLocator.ToString()}");
                    }
                }
                catch (Exception)
                {
                    // If element is not found or scroll fails, attempt another scroll
                    ReportHelper.LogStep($"Element not found, attempting scroll {scrollAttempts + 1}");
                    scrollAttempts++;
                }
               
            }

            if (!isElementFound)
            {
                throw new NoSuchElementException($"Element could not be found after {maxScrollAttempts} scroll attempts: {elementLocator.ToString()}");
            }
        }

        public void ScrollToElement(string text)
        {
            try
            {
                // Scroll into view using the text directly
                driver.FindElement(MobileBy.AndroidUIAutomator(
                    $"new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"{text}\"));"
                ));
            }
            catch (NoSuchElementException e)
            {
                ReportHelper.LogFail("Element not found: " + e.Message);
            }
        }

        //Horizontal Scrol
        
        public void ScrollHorizontallyToElementAndClick(By elementLocator ,string Data)
        
        {
            if (!string.IsNullOrEmpty(Data)) 
            { 

            bool isElementFound = false;
            int maxScrollAttempts = 10; // Limit the number of scroll attempts
            int scrollAttempts = 0;

            while (!isElementFound && scrollAttempts < maxScrollAttempts)
            {
                // Check if the element is present
                var elements = driver.FindElements(elementLocator);

                if (elements.Count > 0)
                {
                    var element = elements.FirstOrDefault(e => e.Displayed && e.Enabled);

                    if (element != null)
                    {
                        element.Click(); // Click the element
                        isElementFound = true;
                        ReportHelper.LogStep($"{Data} clicked successfully!");
                    }
                }

                if (!isElementFound)
                {
                    PerformHorizontalScroll(); // Perform the scroll if element not found
                }

                scrollAttempts++;
            }

            if (!isElementFound)
            {
                throw new Exception($"Element with locator '{elementLocator}' not found after {maxScrollAttempts} scroll attempts.");
            }
        }
}

      
        private void PerformHorizontalScroll()
        {
            // Get screen dimensions
            var horizontalScrollView = driver.FindElement(By.XPath("//android.widget.TextView[@text=\"Transmission\"]/following-sibling::android.widget.HorizontalScrollView"));

            int startX = (int)(horizontalScrollView.Size.Width * 0.8); // Start near the right edge
            int endX = (int)(horizontalScrollView.Size.Width * 0.2);  // End near the left edge
            int centerY = horizontalScrollView.Location.Y + (horizontalScrollView.Size.Height / 2); 

            // Create W3C Actions instance
            var touchDevice = new PointerInputDevice(PointerKind.Touch);
            var actions = new ActionSequence(touchDevice);

            actions.AddAction(touchDevice.CreatePointerMove(CoordinateOrigin.Viewport, startX, centerY, TimeSpan.Zero))
                   .AddAction(touchDevice.CreatePointerDown(PointerButton.TouchContact))
                   .AddAction(touchDevice.CreatePointerMove(CoordinateOrigin.Viewport, endX, centerY, TimeSpan.FromMilliseconds(500)))
                   .AddAction(touchDevice.CreatePointerUp(PointerButton.TouchContact));

            // Perform the actions
            ((AndroidDriver)driver).PerformActions(new List<ActionSequence> { actions });
        }
        //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

        //// Perform horizontal scroll using JavaScript
        //string script = "arguments[0].scrollLeft += 250"; // Scroll right by 250px
        //var element = driver.FindElement(By.XPath("//android.widget.HorizontalScrollView"));
        //js.ExecuteScript(script, element);


        public void ScrollUIHorizontallyToElementAndClick(By elementLocator)
        {
            // Check if the element exists before scrolling
            var elements = driver.FindElements(elementLocator);

            if (elements.Count > 0)
            {
                var element = elements.FirstOrDefault(e => e.Displayed && e.Enabled);

                if (element != null)
                {
                    element.Click(); // If already visible, click directly
                    return;
                }
            }

            // Use AndroidUIAutomator to scroll horizontally
            string uiSelector = "new UiScrollable(new UiSelector().scrollable(true).horizontal(true))"
                                + $".scrollIntoView(new UiSelector().resourceId(\"{ExtractResourceId(elementLocator)}\"));";
            driver.FindElement(MobileBy.AndroidUIAutomator(uiSelector)).Click();
        }

        /// <summary>
        /// Helper method to extract the resource ID from a By locator (XPath, resourceId, etc.)
        /// </summary>
        /// <param name="locator">The By locator for the target element</param>
        /// <returns>Extracted resource ID as a string</returns>
        private string ExtractResourceId(By locator)
        {
            // For simplicity, if you're working with resource IDs directly (e.g., By.Id), extract it here.
            // Modify this function based on your locator patterns.
            if (locator.ToString().StartsWith("By.Id"))
            {
                return locator.ToString().Replace("By.XPath: ", "").Trim();
            }

            throw new NotSupportedException("Locator type not supported for horizontal scrolling.");
        }


    }
}
