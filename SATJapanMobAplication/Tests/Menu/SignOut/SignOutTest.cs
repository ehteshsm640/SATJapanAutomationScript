using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Menu.SignOut;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Menu.SignOut
{
    [TestClass]
    public class SignOutTest:BaseTest
    {

        SignOutPage SignOutPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_SignOut_Cases), DynamicDataSourceType.Method)]
        public void TestCase_SignOut(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_SignOut));
                SignOutPage = new SignOutPage(AndroidDriverManager.driver);

            
                SignOutPage.FillSignOutPage();
               
                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_SignOut) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_SignOut));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_SignOut_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), SignOutPage.SignOutSheetname, "TestCase_SignOut");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
