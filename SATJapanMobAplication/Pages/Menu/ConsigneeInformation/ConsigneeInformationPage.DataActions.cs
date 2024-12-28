using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.ConsigneeInformation
{
    public partial class ConsigneeInformationPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string ConsigneeInformationSheetname = "ConsigneeInformation";
        ExcelHelper excel;

        public string NameData;
        public string PhoneCountryNameSearchData;
        public string PhoneNoData;
       
        public string CountryNameData;
        public string StateData;
        public string CityData;
        
        public string EmailData;
        public string AddressData;
        #region DataActions
        public void LoadConsigneeInformationData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), ConsigneeInformationSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);
          
            NameData = excel.ReadDataFromExcel(nameof(NameData));
            
            PhoneCountryNameSearchData = excel.ReadDataFromExcel(nameof(PhoneCountryNameSearchData));
            PhoneNoData = excel.ReadDataFromExcel(nameof(PhoneNoData));
            CountryNameData = excel.ReadDataFromExcel(nameof(CountryNameData));
            StateData = excel.ReadDataFromExcel(nameof(StateData));
            CityData = excel.ReadDataFromExcel(nameof(CityData));
            EmailData = excel.ReadDataFromExcel(nameof(EmailData));
            AddressData = excel.ReadDataFromExcel(nameof(AddressData));
          
            ReportHelper.LogStep("DataLoaded");
        }
        #endregion DataActions
    }
}
