﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using SATJapanWebApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanWebApplication.Utilities.Browser
{
    public static class DriverManager
    {
        private static IWebDriver driver;
        static ApplicationSettings _settings = ConfigManager.LoadApplicationConfigSetting().ApplicationSettings;
        public static void CreateDriver()
        {
            
            
            switch (_settings.Browser.ToLower())
            {
                case "chrome":
                    driver = CreateChromeDriver(_settings.Headless);
                    break;
                case "firefox":
                    driver = CreateFirefoxDriver(_settings.Headless);
                    break;
                case "edge":
                    driver = CreateEdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Unsupported browser specified in configuration.");
            }

            //driver.Navigate().GoToUrl(_settings.Url);
            //return driver;
        }

        public static IWebDriver CreateChromeDriver(bool headless = false)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-gpu");

            // Enable headless mode if specified
            if (headless)
            {
                chromeOptions.AddArgument("--headless");
            }

            Console.WriteLine("Launching Chrome browser...");
            return new ChromeDriver(chromeOptions);
        }

        public static IWebDriver CreateFirefoxDriver(bool headless = false)
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.AddArgument("--start-maximized");

            // Enable headless mode if specified
            if (headless)
            {
                firefoxOptions.AddArgument("--headless");
            }

            Console.WriteLine("Launching Firefox browser...");
            return new FirefoxDriver(firefoxOptions);
        }

        public static IWebDriver CreateEdgeDriver()
        {
            EdgeOptions edgeOptions = new EdgeOptions();
            Console.WriteLine("Launching Edge browser...");
            return new EdgeDriver(edgeOptions);
        }

        public static IWebDriver CreateSafariDriver()
        {
            SafariOptions safariOptions = new SafariOptions();
            Console.WriteLine("Launching Safari browser...");
            return new SafariDriver(safariOptions);
        }

        public static IWebDriver CreateInternetExplorerDriver()
        {
            InternetExplorerOptions ieOptions = new InternetExplorerOptions();
            ieOptions.IgnoreZoomLevel = true;
            ieOptions.EnableNativeEvents = false;

            Console.WriteLine("Launching Internet Explorer browser...");
            return new InternetExplorerDriver(ieOptions);
        }
        public static void LaunchApplication()
        {
            if (driver != null)
            {
                driver.Navigate().GoToUrl(_settings.Url);
                IWebElement HomeLogo = driver.FindElement(By.XPath("//img[@src='https://satjapan.com/assets/images/logo/logosv.svg']"));
                if (HomeLogo.Displayed) {
                    ReportHelper.LogStep("Succesfully Load Home Page and Validated with SAT Japan Logo ");
                }
            }

        }
        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
                driver.Dispose();
            }
        }
        public static IWebDriver GetDriver()
        {
            return driver;
        }

    }
}
