using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanWebApplication.Utilities;
using SATJapanWebApplication.Utilities.Browser;
using System.Security.Cryptography.X509Certificates;

namespace SATJapanWebApplication.Tests
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

            DriverManager.CreateDriver();
            DriverManager.LaunchApplication();
        }
        [TestCleanup]
        public void TearDown()
        {

            DriverManager.QuitDriver();
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
