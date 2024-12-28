using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace SATJapanMobApplication.Pages.Inquire
{
    public partial class InquirePage
    {
        public By InquireMenu => By.XPath("//android.widget.TextView[@text=\"Inquire\"]");
        public By DestinationCountry => By.XPath("//android.view.ViewGroup[@content-desc=\"Destination Country\"]");
        
        public By DestinationCountrySearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By DestinationCountrySearchResult => By.XPath($"//android.widget.TextView[@text=\"{DestinationCountrySearchData}\"]");
       
        //Will change after above elment value slected 
        public By DestinationPort => By.XPath("//android.view.ViewGroup[@content-desc=\"Destination Port\"]");
        public By DestinationPortSearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By DestinationPortSearchResult => By.XPath($"//android.widget.TextView[@text=\"{DestinationPortSearchData}\"]");
        public By MarineInsuranceFeeYesFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"Yes\"])[1]/android.view.ViewGroup");
        public By PreExportInspectionYesFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"Yes\"])[2]/android.view.ViewGroup");

        //Accepted Currencies
       
        // public By AcceptedCurrencies => By.XPath("//android.widget.TextView[@text=\"Accepted Currencies\"]/..//android.view.ViewGroup[@content-desc=\"Select\"][1]");
        public By Name => By.XPath("//android.widget.EditText[@text=\"Name\"]");
      
        //Country Code 
        public By ContouryCodeButton => By.XPath("//android.widget.TextView[@text=\"🇵🇰\"]");
        public By ContouryCodeSearch => By.XPath("//android.widget.EditText[@resource-id=\"text-input-country-filter\"]");
        public By SelectContouryCode => By.XPath($"//android.view.ViewGroup[contains(@content-desc,'{CountryNameSearchData}')]");

        //phone No
        public By PhoneNo => By.XPath("//android.widget.EditText[@text=\"Phone Number\"]");
        public By Email => By.XPath("//android.widget.EditText[@text=\"Email\"]");
        public By Message => By.XPath("//android.widget.EditText[@text=\"Message\"]");
        public By SubmitButton => By.XPath("//android.view.ViewGroup[@content-desc=\"Submit\"]");
    }
}
