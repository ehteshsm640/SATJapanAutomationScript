using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Menu.Currency;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Menu.Currency
{
    [TestClass]
    public class CurrencyTest:BaseTest
    {

        CurrencyPage CurrencyPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_Currency_Cases), DynamicDataSourceType.Method)]
        public void TestCase_Currency(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_Currency));
                CurrencyPage = new CurrencyPage(AndroidDriverManager.driver);

                CurrencyPage.LoadCurrencyData(rowNumber);
                Thread.Sleep(1000);
                CurrencyPage.FillCurrencyPage();

                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_Currency) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_Currency));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_Currency_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), CurrencyPage.CurrencySheetname, "TestCase_Currency");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
