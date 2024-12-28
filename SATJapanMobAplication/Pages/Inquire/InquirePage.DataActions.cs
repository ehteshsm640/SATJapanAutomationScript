using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Inquire
{
    public partial class InquirePage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string InquireSheetname = "Inquire";
        ExcelHelper excel;

        public string DestinationCountrySearchData;
        public string DestinationPortSearchData;
        public string CountryNameSearchData;
        public string MarineInsuranceFeeYesFlagData;
        public string PreExportInspectionYesFlagData;
        public string NameData;
       // public string ContouryCodeData;
        public string PhoneNoData;
        public string EmailData;
        public string MessageData;
        public string SearchTestData;

        public void LoadInquireData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), InquireSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);
            DestinationCountrySearchData = excel.ReadDataFromExcel(nameof(DestinationCountrySearchData));
            DestinationPortSearchData = excel.ReadDataFromExcel(nameof(DestinationPortSearchData));
            CountryNameSearchData = excel.ReadDataFromExcel(nameof(CountryNameSearchData));
            MarineInsuranceFeeYesFlagData = excel.ReadDataFromExcel(nameof(MarineInsuranceFeeYesFlagData));
            PreExportInspectionYesFlagData = excel.ReadDataFromExcel(nameof(PreExportInspectionYesFlagData));
            NameData = excel.ReadDataFromExcel(nameof(NameData));
           // ContouryCodeData = excel.ReadDataFromExcel(nameof(ContouryCodeData));
            PhoneNoData = excel.ReadDataFromExcel(nameof(PhoneNoData));
            EmailData = excel.ReadDataFromExcel(nameof(EmailData));
            MessageData = excel.ReadDataFromExcel(nameof(MessageData));
            SearchTestData = excel.ReadDataFromExcel(nameof(SearchTestData));

            ReportHelper.LogStep("DataLoaded");
        }
    }
}
