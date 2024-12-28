using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Language
{
    public partial class LanguagePage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string LanguageSheetname = "Language";
        ExcelHelper excel;

        public string LanguageData;
        public string CurrentLanguageData;

        public void LoadLanguageData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), LanguageSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);

            LanguageData = excel.ReadDataFromExcel(nameof(LanguageData));
            CurrentLanguageData = excel.ReadDataFromExcel(nameof(CurrentLanguageData));
          

            ReportHelper.LogStep("DataLoaded");
        }
    }
}
