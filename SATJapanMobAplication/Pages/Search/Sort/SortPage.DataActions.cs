using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Search.Sort
{
    public partial class SortPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string SortSheetname = "Sort";
        ExcelHelper excel;
       

        public string SortByData;

        public void LoadSortData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), SortSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);
            
            SortByData = excel.ReadDataFromExcel(nameof(SortByData));
            ReportHelper.LogStep("DataLoaded");
        }

    }
}
