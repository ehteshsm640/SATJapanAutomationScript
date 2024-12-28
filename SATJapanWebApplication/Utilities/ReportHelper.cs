using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace SATJapanWebApplication.Utilities
{
    public static class ReportHelper
    {
        private static ExtentReports _extent;
        private static ExtentTest _test;

        public static ExtentReports Extent
        {
            get
            {
                if (_extent == null)
                {
                    InitializeReport();
                }
                return _extent;
            }
        }

    public static void InitializeReport()
    {
        if (_extent == null) // Only initialize once
        {
            // Create a directory for logs/reports
            string reportDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", DateTime.Now.ToString("yyyy-MM-dd"));
            Directory.CreateDirectory(reportDirectory);

                //string reportFilePath = Path.Combine(reportDirectory, $"ExtentReport_{DateTime.Now:yyyy-MM-dd}.html");
                string reportFilePath = Path.Combine(reportDirectory, $"ExtentReport_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.html");
                // Initialize Extent Report with an HTML reporter
                var htmlReporter = new ExtentSparkReporter(reportFilePath);
            _extent = new ExtentReports();
            _extent.AttachReporter(htmlReporter);

                _extent.AddSystemInfo("Environment", "Production");
                _extent.AddSystemInfo("User Name", Environment.UserName);
                _extent.AddSystemInfo("Machine Name", Environment.MachineName);
            }
    }


    public static void CreateTest(string testName)
        {
            // Create a test node for the current test method
            _test = Extent.CreateTest(testName);
        }

        public static void LogStep(string stepDescription)
        {
            _test.Log(Status.Info, stepDescription);
        }

        public static void LogPass(string message)
        {
            _test.Log(Status.Pass, message);
        }

        public static void LogFail(string message)
        {
            _test.Log(Status.Fail, message);
        }

        //public static void FlushReport()
        //{
        //    // Close the extent report when all tests are done
        //    Extent.Flush();
        //}
        public static void FlushReport()
        {
            if (_extent != null)
            {
                _extent.Flush(); // Writes everything to the report
            }
        }

    }
}
