using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace SATJapanMobApplication.Pages.Search.Filters
{
    public partial class FiltersPage:BasePage
    {
        public  FiltersPage(AndroidDriver driver):base(driver){ }
        public By SearchMenu => MobileBy.AccessibilityId("Search");
        public By FiltersMenu => MobileBy.XPath("//android.widget.TextView[@text=\"Filters\"]");
        public By SeefulllistButton => MobileBy.XPath("//android.widget.TextView[@text=\"See full list\"]");
        public By SearchUsedCar => MobileBy.XPath("//android.widget.EditText[@text=\"Search used car\"]");
        public By Make => MobileBy.XPath($"//android.view.ViewGroup[@content-desc=\"{MakeData}\"]");
        public By Model => MobileBy.XPath($"//android.widget.TextView[@text=\"{ModelData}\"]");
        public By DoneButton => MobileBy.XPath("//android.widget.TextView[@text=\"Done\"]");
        public By ModelCode => MobileBy.XPath("//android.widget.TextView[@text=\"Model Code\"]/../android.view.ViewGroup[2]");
        public By YearMin => MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"Max\"])[1]");
        public By Search => MobileBy.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By SelectYearMin => MobileBy.XPath($"//android.widget.TextView[@text=\"{YearMinData}\"]");
        public By YearMax => MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"Max\"])[1]");
        public By SelectYearMax => MobileBy.XPath($"//android.widget.TextView[@text=\"{YearMaxData}\"]");
        // need to be change
        public By PriceMin => MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"Max\"])[1]");
        public By SelectPriceMin => MobileBy.XPath($"//android.widget.TextView[@text=\"{PriceMinData}\"]");
        public By PriceMax => MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"Max\"])[1]");
        public By SelectPriceMax => MobileBy.XPath($"//android.widget.TextView[@text=\"{PriceMaxData}\"]");
        public By MileageMin => MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"Max\"])[1]");
        public By SelectMileageMin => MobileBy.XPath($"//android.widget.TextView[@text=\"{MileageMinData}\"]");
        public By MileageMax => MobileBy.XPath("(//android.view.ViewGroup[@content-desc=\"Max\"])[1]");
        public By SelectMileageMax => MobileBy.XPath($"//android.widget.TextView[@text=\"{MileageMaxData}\"]");
        public By Steering => MobileBy.XPath($"//android.view.ViewGroup[@content-desc=\"{SteeringData}\"]");
        public By Transmission => MobileBy.XPath($"//android.widget.TextView[@text=\"Transmission\"]/following-sibling::android.widget.HorizontalScrollView//android.view.ViewGroup[@content-desc=\"{TransmissionData}\"]");
        public By EngineSize => MobileBy.XPath("(//android.widget.TextView[@text=\"Engine Size\"]/following-sibling::android.view.ViewGroup)[1]");
        public By SelectEngineSize => MobileBy.XPath($"//android.widget.TextView[@text=\"{EngineSizeData}\"]");
        public By FuelType => MobileBy.XPath($"(//android.widget.TextView[@text=\"Fuel Type\"]/following-sibling::android.widget.HorizontalScrollView)[1]//android.view.ViewGroup[@content-desc=\"{FuelTypeData}\"]");
        public By BodyType => MobileBy.XPath($"(//android.widget.TextView[@text=\"Body Type\"]/following-sibling::android.widget.HorizontalScrollView)[1]//android.view.ViewGroup[@content-desc=\"{BodyTypeData}\"]");
        public By Color => MobileBy.XPath($"//android.widget.TextView[@text=\"Color\"]/following-sibling::android.widget.HorizontalScrollView//android.view.ViewGroup[{ColorIndexData}]");
        public By LoadCapacityMin => MobileBy.XPath($"//android.view.ViewGroup[@content-desc=\"Min\"]");
        public By SelectLoadCapacityMin => MobileBy.XPath($"//android.widget.TextView[@text=\"{LoadCapacityMinData}\"]");
        public By LoadCapacityMax => MobileBy.XPath($"//android.view.ViewGroup[@content-desc=\"Max\"]");
        public By SelectLoadCapacityMax => MobileBy.XPath($"//android.widget.TextView[@text=\"{LoadCapacityMaxData}\"]");
        public By Location => MobileBy.XPath("(//android.widget.TextView[@text=\"Location\"]/following-sibling::android.view.ViewGroup)[1]");
        public By SelectLocation => MobileBy.XPath($"//android.widget.TextView[@text=\"{LocationData}\"]");
        public By Drivetrain => MobileBy.XPath("(//android.widget.TextView[@text=\"Drivetrain\"]/following-sibling::android.view.ViewGroup)[1]");
        public By SelectDrivetrain => MobileBy.XPath($"//android.widget.TextView[@text=\"{DrivetrainData}\"]");
        public By Seats => MobileBy.XPath("(//android.widget.TextView[@text=\"Seats\"]/following-sibling::android.view.ViewGroup)[1]");
        public By SelectSeats => MobileBy.XPath($"//android.widget.TextView[@text=\"{SeatsData}\"]");
        public By AditionalFeaturesMenu => MobileBy.XPath("//android.widget.TextView[@text=\"Additional Features\"]");
        public By AditionalFeatures => MobileBy.XPath($"//android.widget.TextView[@text=\"{AditionalFeaturesData}\"]/../android.view.ViewGroup");
        public By ApplyButton => MobileBy.XPath("//android.widget.TextView[@text=\"Apply\"]");
        public By ResetButton => MobileBy.XPath("//android.widget.TextView[@text=\"Reset\"]");
    }
}
