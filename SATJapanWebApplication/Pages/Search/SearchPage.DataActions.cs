using OpenQA.Selenium;
using SATJapanWebApplication.Utilities;
using SATJapanWebApplication.Pages.Base;
using SATJapanWebApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using SATJapanWebApplication.Utilities.Helper;
using OpenQA.Selenium.BiDi.Modules.Script;

namespace SATJapanWebApplication.Pages.Search
{
    public partial class SearchPage 
    {
       public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string SearchSheetname= "Search";
        ExcelHelper excel;

        
        string MakeData;
        string ModelData;
        string TypeData;
        string SteeringData;
        string MinYearData;
        string MaxYearData;
        string StockIDData;





        public void LoadData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), SearchSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);
            MakeData = excel.ReadDataFromExcel(nameof(MakeData));
            ModelData = excel.ReadDataFromExcel(nameof(ModelData));
            TypeData = excel.ReadDataFromExcel(nameof(TypeData));
            SteeringData = excel.ReadDataFromExcel(nameof(SteeringData));
            MinYearData = excel.ReadDataFromExcel(nameof(MinYearData));
            MaxYearData = excel.ReadDataFromExcel(nameof(MaxYearData));
            StockIDData = excel.ReadDataFromExcel(nameof(StockIDData));
            ReportHelper.LogStep("DataLoaded");
        }
      
      
       
    }
}
