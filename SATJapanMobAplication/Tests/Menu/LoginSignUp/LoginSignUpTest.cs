using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Pages.Menu.LoginSignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Menu.LoginSignUp
{
    [TestClass]
    public class LoginSignUpTest : BaseTest
    {

        LoginSignUpPage LoginSignUpPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_LoginSignUp_Cases), DynamicDataSourceType.Method)]
        public void TestCase_LoginSignUp(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_LoginSignUp));
                LoginSignUpPage = new LoginSignUpPage(AndroidDriverManager.driver);
                LoginSignUpPage.LoadLoginSignUpData(rowNumber);
                LoginSignUpPage.FillLoginSignUpPage();

                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_LoginSignUp) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_LoginSignUp));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_LoginSignUp_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), LoginSignUpPage.LoginSignUpSheetname, "TestCase_LoginSignUp");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
