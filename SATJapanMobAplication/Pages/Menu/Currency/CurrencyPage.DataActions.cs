using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Currency
{
    public partial class CurrencyPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string CurrencySheetname = "Currency";
        ExcelHelper excel;

        public string SearchCurrencyData;

        public void LoadCurrencyData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), CurrencySheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);

            SearchCurrencyData = excel.ReadDataFromExcel(nameof(SearchCurrencyData));
          
            ReportHelper.LogStep("DataLoaded");
        }
    }
}
