using OpenQA.Selenium.BiDi.Modules.Script;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.DeactivateAccount
{
    public partial class DeactivateAccountPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string DeactivateAccountSheetname = "DeactivateAccount";
        ExcelHelper excel;

        public string ExplainReasonData;
        public void LoadDeactivateAccountData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), DeactivateAccountSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);

            ExplainReasonData = excel.ReadDataFromExcel(nameof(ExplainReasonData));
            excel.CloseWorkBook();
        }
        }
}
