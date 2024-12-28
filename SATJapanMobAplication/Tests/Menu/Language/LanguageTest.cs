using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Menu.Language;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Menu.Language
{
    [TestClass]
    public class LanguageTest:BaseTest
    {
        LanguagePage LanguagePage;
        [TestMethod]
        [DynamicData(nameof(TestCase_Language_Cases), DynamicDataSourceType.Method)]
        public void TestCase_Language(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_Language));
                LanguagePage = new LanguagePage(AndroidDriverManager.driver);

                LanguagePage.LoadLanguageData(rowNumber);
                Thread.Sleep(1000);
                LanguagePage.FillLanguagePage();

                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_Language) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_Language));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_Language_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), LanguagePage.LanguageSheetname, "TestCase_Language");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
