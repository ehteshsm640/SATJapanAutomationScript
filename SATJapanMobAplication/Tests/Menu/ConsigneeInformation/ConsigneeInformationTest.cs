using Microsoft.VisualStudio.TestTools.UnitTesting;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.AndroidDriverManager;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Pages.Menu.ConsigneeInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Tests.Menu.ConsigneeInformation
{
    [TestClass]
    public class ConsigneeInformationTest:BaseTest
    {
        ConsigneeInformationPage ConsigneeInformationPage;
        [TestMethod]
        [DynamicData(nameof(TestCase_ConsigneeInformation_Cases), DynamicDataSourceType.Method)]
        public void TestCase_ConsigneeInformation(int rowNumber)
        {
            try
            {
                ReportHelper.CreateTest(nameof(TestCase_ConsigneeInformation));
                ConsigneeInformationPage = new ConsigneeInformationPage(AndroidDriverManager.driver);
           
                ConsigneeInformationPage.LoadConsigneeInformationData(rowNumber);
                Thread.Sleep(1000);
                ConsigneeInformationPage.FillConsigneeInformation();
                ReportHelper.LogPass("Test Run Succesfuly");
            }
            catch (Exception ex)
            {
                ReportHelper.LogFail(nameof(TestCase_ConsigneeInformation) + "Fail");
                ScreenshotHelper screenshot = new ScreenshotHelper(AndroidDriverManager.driver);
                screenshot.CaptureScreenshot(nameof(TestCase_ConsigneeInformation));
                Assert.Fail($"Test failed with exception: {ex.Message}");
            }
        }

        public static IEnumerable<object[]> TestCase_ConsigneeInformation_Cases()
        {
            List<int> rowNumbers = ExcelHelper.GetTestCaseRows(ConfigManager.GetSATJapanExcelPath(), ConsigneeInformationPage.ConsigneeInformationSheetname, "TestCase_ConsigneeInformation");

            foreach (var rowNumber in rowNumbers)
            {
                yield return new object[] { rowNumber };
            }
        }
    }
}
