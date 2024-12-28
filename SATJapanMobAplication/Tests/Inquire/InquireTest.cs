using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Buy_Now;
using SATJapanMobApplication.Pages.Inquire;
using SATJapanMobApplication.Pages.Search;
using SATJapanMobApplication.Tests;
using SATJapanMobApplication.Tests.Search;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using System.Collections.Generic;

namespace SATJapanMobApplication.Tests.Inquire
{
    [TestClass]
    public class InquireTest : BaseTest
    {
        SearchTest SearchTest = new SearchTest(); //For Searching
        InquirePage InquirePage;
        [TestMethod]
        [DynamicData(nameof(TestCase_InquirePage_Cases), DynamicDataSourceType.Method)]
        public void TestCase_Inquire(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_Inquire));
                InquirePage = new InquirePage(AndroidDriverManager.driver);
                InquirePage.LoadInquireData(rowNumber);
                SearchTest.TestCase_SearchThroughNev(Convert.ToInt32(InquirePage.SearchTestData));
        
                Thread.Sleep(1000);
                InquirePage.FillInquirePage();
                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch(Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_Inquire) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_Inquire));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_InquirePage_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), InquirePage.InquireSheetname, "TestCase_Inquire");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }

    }
}