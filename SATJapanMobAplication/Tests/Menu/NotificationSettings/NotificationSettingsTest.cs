using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Pages.Menu.NotificationSettings;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Menu.NotificationSettings
{
    [TestClass]
    public class NotificationSettingsTest:BaseTest
    {
        NotificationSettingsPage NotificationSettingsPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_NotificationSettings_Cases), DynamicDataSourceType.Method)]
        public void TestCase_NotificationSettings(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_NotificationSettings));
                NotificationSettingsPage = new NotificationSettingsPage(AndroidDriverManager.driver);

                NotificationSettingsPage.LoadNotificationSettingsData(rowNumber);
                Thread.Sleep(1000);
                NotificationSettingsPage.FillNotificationSettingsPage();
              
                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_NotificationSettings) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_NotificationSettings));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_NotificationSettings_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), NotificationSettingsPage.NotificationSettingsSheetname, "TestCase_NotificationSettings");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
