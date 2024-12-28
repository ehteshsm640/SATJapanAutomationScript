using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using System;
using System.IO;

namespace SATJapanMobApplication.Utilities
{
    public  class ScreenshotHelper
    {
        private readonly AndroidDriver _driver;

        public ScreenshotHelper(AndroidDriver driver)
        {
            _driver = driver;
        }

        public void CaptureScreenshot(string testName)
        {
            try
            {
                Screenshot screenshot = ((ITakesScreenshot)_driver).GetScreenshot();

                // Define the base directory and log directory
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string logDirectory = Path.Combine(baseDirectory, "Logs");

                // Create the Logs folder if it doesn't exist
                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }

                // Create a subfolder with today's date
                string dateDirectory = Path.Combine(logDirectory, DateTime.Now.ToString("yyyy-MM-dd"));
                if (!Directory.Exists(dateDirectory))
                {
                    Directory.CreateDirectory(dateDirectory);
                }

                // Save the screenshot in the dated folder
                string screenshotPath = Path.Combine(dateDirectory, $"{testName}_{DateTime.Now:HHmmss}.png");
                screenshot.SaveAsFile(screenshotPath);

                Console.WriteLine($"Screenshot saved: {screenshotPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to capture screenshot: {ex.Message}");
            }
        }
    }
}
