using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Tests.Search;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATJapanMobApplication.Pages.Buy_Now;

namespace SATJapanMobApplication.Tests.Buy_Now
{
    [TestClass]
    public class BuyNowTest:BaseTest
    {
        SearchTest SearchTest = new SearchTest(); //For Searching
        BuyNowPage BuyNowPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_BuyNowPage_Cases), DynamicDataSourceType.Method)]
        public void TestCase_BuyNow(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_BuyNow));
                BuyNowPage = new BuyNowPage(AndroidDriverManager.driver);
                BuyNowPage.LoadBuyNowData(rowNumber);
                SearchTest.TestCase_SearchThroughNev(Convert.ToInt32(BuyNowPage.SearchTestData));
                Thread.Sleep(1000);
                BuyNowPage.FillBuyNowPage();
                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_BuyNow) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_BuyNow));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_BuyNowPage_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), BuyNowPage.BuyNowSheetname, "TestCase_BuyNowTest");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
