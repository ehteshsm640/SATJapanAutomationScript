using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.Helper;
using SATJapanMobApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.LoginSignUp
{
    public partial class LoginSignUpPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string LoginSignUpSheetname = "LoginSignUp";
        ExcelHelper excel;

        public string EmailData;
        public string TermConditionData;
        public string PrivicyNoticeData;
        public string NameData;
        public string PasswordData;
        public string ConfirmPasswordData;
        public string ForgotPasswordData;
        public string OTPData;
        public void LoadLoginSignUpData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), LoginSignUpSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);

            EmailData = excel.ReadDataFromExcel(nameof(EmailData));
            TermConditionData = excel.ReadDataFromExcel(nameof(TermConditionData));
            PrivicyNoticeData = excel.ReadDataFromExcel(nameof(PrivicyNoticeData));
            NameData = excel.ReadDataFromExcel(nameof(NameData));
            PasswordData = excel.ReadDataFromExcel(nameof(PasswordData));
            ConfirmPasswordData = excel.ReadDataFromExcel(nameof(ConfirmPasswordData));
            ForgotPasswordData = excel.ReadDataFromExcel(nameof(ForgotPasswordData));
            OTPData = excel.ReadDataFromExcel(nameof(OTPData));

            ReportHelper.LogStep("DataLoaded");
        }
    }
}
