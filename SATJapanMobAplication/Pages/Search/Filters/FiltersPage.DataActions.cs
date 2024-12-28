using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Search.Filters
{
    public partial class FiltersPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string FilterSheetname = "Filter";
        ExcelHelper excel;


        public string MakeData;
        public string ModelData;
        public string ModelCodeData;
        public string SteeringData;
        public string YearMinData;
        public string YearMaxData;
        public string PriceMinData;
        public string PriceMaxData;
        public string MileageMinData;
        public string MileageMaxData;
        public string TransmissionData;
        public string EngineSizeData;
        public string FuelTypeData;
        public string BodyTypeData;
        public string ColorIndexData;
        public string LoadCapacityMinData;
        public string LoadCapacityMaxData;
        public string LocationData;
        public string DrivetrainData;
        public string SeatsData;
        public string AditionalFeaturesData;

        public void LoadFilterData(int rownumber)
        {
            excel = new ExcelHelper(ConfigManager.GetSATJapanExcelPath(), FilterSheetname);
            excel.SetHeaderRow();
            excel.SetDataRow(rownumber);

            MakeData = excel.ReadDataFromExcel(nameof(MakeData));
            ModelData = excel.ReadDataFromExcel(nameof(ModelData));
            ModelCodeData = excel.ReadDataFromExcel(nameof(ModelCodeData));
            SteeringData = excel.ReadDataFromExcel(nameof(SteeringData));
            YearMinData = excel.ReadDataFromExcel(nameof(YearMinData));
            YearMaxData = excel.ReadDataFromExcel(nameof(YearMaxData));
            PriceMinData = excel.ReadDataFromExcel(nameof(PriceMinData));
            PriceMaxData = excel.ReadDataFromExcel(nameof(PriceMaxData));
            MileageMinData = excel.ReadDataFromExcel(nameof(MileageMinData));
            MileageMaxData = excel.ReadDataFromExcel(nameof(MileageMaxData));
            TransmissionData = excel.ReadDataFromExcel(nameof(TransmissionData));
            EngineSizeData = excel.ReadDataFromExcel(nameof(EngineSizeData));
            FuelTypeData = excel.ReadDataFromExcel(nameof(FuelTypeData));
            BodyTypeData = excel.ReadDataFromExcel(nameof(BodyTypeData));
            ColorIndexData = excel.ReadDataFromExcel(nameof(ColorIndexData));
            LoadCapacityMinData = excel.ReadDataFromExcel(nameof(LoadCapacityMinData));
            LoadCapacityMaxData = excel.ReadDataFromExcel(nameof(LoadCapacityMaxData));
            LocationData = excel.ReadDataFromExcel(nameof(LocationData));
            DrivetrainData = excel.ReadDataFromExcel(nameof(DrivetrainData));
            SeatsData = excel.ReadDataFromExcel(nameof(SeatsData));
            AditionalFeaturesData = excel.ReadDataFromExcel(nameof(AditionalFeaturesData));
            ReportHelper.LogStep("DataLoaded");
        }
    }
}
