using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using System.Security.Cryptography.X509Certificates;

namespace SATJapanMobApplication.Tests
{
    [TestClass]
    public class BaseTest
    {
        [AssemblyInitialize]
        public static void SetUpClass(TestContext context)
        {
            // Initialize report only once for the test class
            ReportHelper.InitializeReport();
        }
        [TestInitialize]
        public void SetUp()
        {
           
           // ReportHelper.LogStep("Test Setup started.");

            AndroidDriverManager.InitializeDriver();
            AndroidDriverManager.LaunchApplication();
        }
        [TestCleanup]
        public void TearDown()
        {
            
            AndroidDriverManager.QuitDriver();
            ReportHelper.LogStep("Driver quit successfully.");
           
        }

        [AssemblyCleanup]
        public static void TearDownClass()
        {
            // Flush report after all tests are done
            ReportHelper.FlushReport();
        }
    }
}
