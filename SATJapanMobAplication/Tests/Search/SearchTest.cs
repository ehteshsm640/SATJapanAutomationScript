using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
using System.Runtime.CompilerServices;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Pages.Search;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Tests;
using SATJapanMobApplication.Pages.Search;
using SATJapanMobApplication.Pages.LandingHomePage;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Configuration;


namespace SATJapanMobApplication.Tests.Search
{
    [TestClass]
    public  class SearchTest:BaseTest
    {
        SearchPage SearchPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_SearchThroughNev_Cases), DynamicDataSourceType.Method)]
        public void TestCase_SearchThroughNev(int RowNumber)
        {

            ReportHelper.CreateTest(nameof(TestCase_SearchThroughNev));
            SearchPage = new SearchPage(AndroidDriverManager.driver);
            try
            {   
                SearchPage.LoadData(RowNumber);
                SearchPage.ClickSearchMenu();
                Thread.Sleep(5000);
               SearchPage.ScrollAndClickElement();
                ReportHelper.LogPass("Test Run Succesfuly");

            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_SearchThroughNev) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_SearchThroughNev));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }

        }
        public static IEnumerable<object[]> TestCase_SearchThroughNev_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), SearchPage.SearchSheetname, "TestCase_SearchThroughNev");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }

    }
}
