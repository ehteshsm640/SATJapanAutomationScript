using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATJapanMobApplication.Pages.Menu.DeactivateAccount;

namespace SATJapanMobApplication.Tests.Menu.DeactivateAccount
{
    [TestClass]
    public class DeactivateAccountTest:BaseTest
    {
        DeactivateAccountPage DeactivateAccountPage;
         [TestMethod]
        [DynamicData(nameof(TestCase_DeactivateAccount_Cases), DynamicDataSourceType.Method)]
        public void TestCase_DeactivateAccount(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_DeactivateAccount));
                DeactivateAccountPage = new DeactivateAccountPage(AndroidDriverManager.driver);

                DeactivateAccountPage.LoadDeactivateAccountData(rowNumber);
                Thread.Sleep(1000);
                DeactivateAccountPage.FillDeactivateAccountPage();
                if(!DeactivateAccountPage.Validatetext()) Assert.Fail();
                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_DeactivateAccount) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_DeactivateAccount));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_DeactivateAccount_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), DeactivateAccountPage.DeactivateAccountSheetname, "TestCase_DeactivateAccount");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
