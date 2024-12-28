using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.NotificationSettings
{
    public partial class NotificationSettingsPage
    {

        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string NotificationSettingsSheetname = "NotificationSettings";
        ExcelHelper excel;

        public string AllowAllNotificationsCheckboxData;
        public string SMSNotificationsCheckboxData;
        public string EmailNotificationCheckboxData;
        public void LoadNotificationSettingsData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), NotificationSettingsSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);

            AllowAllNotificationsCheckboxData = excel.ReadDataFromExcel(nameof(AllowAllNotificationsCheckboxData));
            SMSNotificationsCheckboxData = excel.ReadDataFromExcel(nameof(SMSNotificationsCheckboxData));
            EmailNotificationCheckboxData = excel.ReadDataFromExcel(nameof(EmailNotificationCheckboxData));
            excel.CloseWorkBook();
        }
    }

}
