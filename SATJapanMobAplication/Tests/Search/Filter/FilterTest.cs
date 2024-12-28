using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Search.Filters;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Search.Filter
{
    [TestClass]
    public class FilterTest:BaseTest
    {

        FiltersPage FiltersPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_Filter_Cases), DynamicDataSourceType.Method)]
        public void TestCase_Filter(int RowNumber)
        {

            ReportHelper.CreateTest(nameof(TestCase_Filter));
            FiltersPage = new FiltersPage(AndroidDriverManager.driver);
            try
            {
                FiltersPage.LoadFilterData(RowNumber);
                FiltersPage.FillFilterPage();
                ReportHelper.LogPass("Test Run Succesfuly");

            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_Filter) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_Filter));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }

        }
        public static IEnumerable<object[]> TestCase_Filter_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), FiltersPage.FilterSheetname, "TestCase_Filter");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
