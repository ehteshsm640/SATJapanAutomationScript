using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Buy_Now
{
    public partial class BuyNowPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string BuyNowSheetname = "BuyNow";

        ExcelHelper excel;
        public string DestinationCountrySearchData;
        public string DestinationPortSearchData;
        
        public string MarineInsuranceFeeFlagData;
        public string PreExportInspectionFlagData;
        public string SATWarrantyFlagData;
        public string WarrantyNoticeButtonData;

        public string AcceptedCountrySearchData;

       
        public string NameData;
        public string PhoneContouryCodeSearchData;
        public string PhoneNoData;
        public string EmailData;
        public string AddressData;
        public string AddressCountrySearchData;
        public string AddressCitySearchData;
        public string CouponCodeData;

        public string SearchTestData;

        public void LoadBuyNowData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), BuyNowSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);
            DestinationCountrySearchData = excel.ReadDataFromExcel(nameof(DestinationCountrySearchData));
            DestinationPortSearchData = excel.ReadDataFromExcel(nameof(DestinationPortSearchData));

            MarineInsuranceFeeFlagData = excel.ReadDataFromExcel(nameof(MarineInsuranceFeeFlagData));
            PreExportInspectionFlagData = excel.ReadDataFromExcel(nameof(PreExportInspectionFlagData));
            SATWarrantyFlagData = excel.ReadDataFromExcel(nameof(SATWarrantyFlagData));

            AcceptedCountrySearchData = excel.ReadDataFromExcel(nameof(AcceptedCountrySearchData));

            NameData = excel.ReadDataFromExcel(nameof(NameData));
            PhoneContouryCodeSearchData = excel.ReadDataFromExcel(nameof(PhoneContouryCodeSearchData));
            PhoneNoData = excel.ReadDataFromExcel(nameof(PhoneNoData));
            EmailData = excel.ReadDataFromExcel(nameof(EmailData));
            AddressData = excel.ReadDataFromExcel(nameof(AddressData));
            AddressCountrySearchData = excel.ReadDataFromExcel(nameof(AddressCountrySearchData));
            AddressCitySearchData = excel.ReadDataFromExcel(nameof(AddressCitySearchData));
            SearchTestData = excel.ReadDataFromExcel(nameof(SearchTestData));

            ReportHelper.LogStep("DataLoaded");
        }
    }
}
