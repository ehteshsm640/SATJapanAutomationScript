using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Search.Filters
{
    public partial class FiltersPage
    {
        public void FillFilterPage()
        {
            Click(SearchMenu, nameof(SearchMenu));
            Click(FiltersMenu, nameof(FiltersMenu));

            Click(SeefulllistButton, nameof(SeefulllistButton));
            EnterText(SearchUsedCar, MakeData);
            Click(Make, MakeData);

            ScrollToElement(ModelData);
            Click(Model, ModelData);
            Click(DoneButton, nameof(DoneButton));

            EnterText(ModelCode, ModelCodeData);

            if (!string.IsNullOrEmpty(YearMinData))
            {
                Click(YearMin, nameof(YearMin));
                EnterText(Search, YearMinData);
                Click(SelectYearMin, YearMinData);
            }

            if (!string.IsNullOrEmpty(YearMaxData))
            {
                Click(YearMax, nameof(YearMax));
                EnterText(Search, YearMaxData);
                Click(SelectYearMax, YearMaxData);
            }

            if (!string.IsNullOrEmpty(PriceMinData))
            {
                Click(PriceMin, nameof(PriceMin));
                EnterText(Search, PriceMinData);
                Click(SelectPriceMin, PriceMinData);
            }

            if (!string.IsNullOrEmpty(PriceMaxData))
            {
                Click(PriceMax, nameof(PriceMax));
                EnterText(Search, PriceMaxData);
                Click(SelectPriceMax, PriceMaxData);
            }
            if (!string.IsNullOrEmpty(MileageMinData))
            {
                Click(MileageMin, nameof(MileageMin));
                EnterText(Search, MileageMinData);
                Click(SelectMileageMin, MileageMinData);
            }
            if (!string.IsNullOrEmpty(MileageMaxData))
            {
                Click(MileageMax, nameof(MileageMax));
                EnterText(Search, MileageMaxData);
                Click(SelectMileageMax, MileageMaxData);
            }
           
            Click(Steering, SteeringData);

            ScrollToElement("Color");
            ScrollHorizontallyToElementAndClick(Transmission, TransmissionData);

            if (!string.IsNullOrEmpty(EngineSizeData))
            {
                Click(EngineSize, nameof(EngineSize));
                EnterText(Search, EngineSizeData);
                Click(SelectEngineSize, EngineSizeData);
            }
            ScrollHorizontallyToElementAndClick(FuelType, FuelTypeData);

            ScrollHorizontallyToElementAndClick(BodyType, BodyTypeData);

            if (!string.IsNullOrEmpty(LoadCapacityMinData))
            {
                Click(LoadCapacityMin, nameof(LoadCapacityMin));
                EnterText(Search, LoadCapacityMinData);
                Click(SelectLoadCapacityMin, LoadCapacityMinData);
            }
            if (!string.IsNullOrEmpty(LoadCapacityMaxData))
            {
                Click(LoadCapacityMax, nameof(LoadCapacityMax));
                EnterText(Search, LoadCapacityMaxData);
                Click(SelectLoadCapacityMax, LoadCapacityMaxData);
            }
            if (!string.IsNullOrEmpty(LocationData))
            {
                Click(Location, nameof(Location));
                EnterText(Search, LocationData);
                Click(SelectLocation, LocationData);
            }
            ScrollDown();

            Click(Color,nameof(Color));

            if (!string.IsNullOrEmpty(DrivetrainData))
            {
                Click(Drivetrain, nameof(Drivetrain));
                EnterText(Search, DrivetrainData);
                Click(SelectDrivetrain, DrivetrainData);
            }
            if (!string.IsNullOrEmpty(SeatsData))
            {
                Click(Seats, nameof(Seats));
                EnterText(Search, SeatsData);
                Click(SelectSeats, SeatsData);
            }
            if (!string.IsNullOrEmpty(AditionalFeaturesData))
            {
                Click(AditionalFeatures, nameof(AditionalFeatures));
                ScrollDown();
                
                Click(AditionalFeatures, AditionalFeaturesData);
                ScrollDown();
            }

            // if(!string.IsNullOrEmpty(Luxery))
            Click(ApplyButton,nameof(ApplyButton));
        }
    }
}
