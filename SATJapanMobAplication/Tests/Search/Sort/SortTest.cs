using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Search.Sort;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Search.Sort
{
    [TestClass]
    public  class SortTest:BaseTest
    {
        SortPage SortPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_Sort_Cases), DynamicDataSourceType.Method)]
        public void TestCase_Sort(int RowNumber)
        {

            ReportHelper.CreateTest(nameof(TestCase_Sort));
            SortPage = new SortPage(AndroidDriverManager.driver);
            try
            {
                SortPage.LoadSortData(RowNumber);
                SortPage.FillSortPage();
                ReportHelper.LogPass("Test Run Succesfuly");

            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_Sort) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_Sort));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }

        }
        public static IEnumerable<object[]> TestCase_Sort_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), SortPage.SortSheetname, "TestCase_Sort");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
