using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Buy_Now
{
    public partial class BuyNowPage
    {
        public By BuyNowMenu => By.XPath("//android.widget.TextView[@text='Buy Now']");
        public By DestinationCountry => By.XPath("//android.view.ViewGroup[@content-desc='Destination Country']");

        public By DestinationCountrySearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By DestinationCountrySearchResult => By.XPath($"//android.widget.TextView[@text=\"{DestinationCountrySearchData}\"]");

        //Will change after above elment value slected 
        public By DestinationPort => By.XPath("//android.view.ViewGroup[@content-desc=\"Destination Port\"]");
        public By DestinationPortSearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By DestinationPortSearchResult => By.XPath($"//android.widget.TextView[@text=\"{DestinationPortSearchData}\"]");
        public By MarineInsuranceFeeYesFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"Yes\"])[1]/android.view.ViewGroup");
        public By PreExportInspectionYesFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"Yes\"])[2]/android.view.ViewGroup");
       
        public By MarineInsuranceFeeNoFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"No\"])[1]/android.view.ViewGroup");
        public By PreExportInspectionNoFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"No\"])[2]/android.view.ViewGroup");

        public By SATWarrantyYesFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"Yes\"])[3]/android.view.ViewGroup");
        public By SATWarrantyNoFlag => By.XPath("(//android.view.ViewGroup[@content-desc=\"No\"])[3]/android.view.ViewGroup");
        public By WarrantyNoticeYesButton => By.XPath("//android.widget.TextView[@text=\"Yes\"]");
        public By WarrantyNoticeNoButton => By.XPath("//android.widget.TextView[@text=\"No\"]");

        public By AcceptedCurrencies => By.XPath("//android.view.ViewGroup[@content-desc=\"British Pound Sterling\"]/android.view.ViewGroup");
        public By AcceptedCurrenciesSearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By AcceptedCurrenciesSearchResult => By.XPath($"//android.widget.TextView[@text=\"{AcceptedCountrySearchData}\"]");

       
        public By ContinueButton => By.XPath("//android.widget.TextView[@text=\"Continue\"]");

        public By AddAddressButton => By.XPath("//android.widget.TextView[@text=\"Add Address\"]");

        public By Name => By.XPath("//android.widget.EditText[@text=\"Name\"]");

        //Country Code 
        public By PhoneContouryCodeButton => By.XPath("//android.widget.TextView[@text=\"🇵🇰\"]");
        public By PhoneContouryCodeSearch => By.XPath("//android.widget.EditText[@resource-id=\"text-input-country-filter\"]");
        public By PhoneSelectContouryCode => By.XPath($"//android.view.ViewGroup[contains(@content-desc,'{PhoneContouryCodeSearchData}')]");

        //phone No
        public By PhoneNo => By.XPath("//android.widget.EditText[@text=\"Phone Number\"]");
        public By Email => By.XPath("//android.widget.EditText[@text=\"Email\"]");

        public By Address => By.XPath("//android.widget.EditText[@text=\"Street\"]");

        public By AddressCountryButton => By.XPath("//android.view.ViewGroup[@content-desc=\"Country\"]");
        public By AddressContourySearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By AddressContourySearchResult => By.XPath($"//android.widget.TextView[@text=\"{AddressCountrySearchData}\"]");

        public By AddressCity => By.XPath("//android.view.ViewGroup[@content-desc=\"City\"]");
        public By AddressCitySearch => By.XPath("//android.widget.EditText[@text=\"Search\"]");
        public By AddressCitySearchResult => By.XPath($"//android.widget.TextView[@text=\"{AddressCitySearchData}\"]");

        public By SubmitButton => By.XPath("//android.widget.TextView[@text=\"Submit\"]");
        public By CouponCode => By.XPath("//android.widget.EditText[@text=\"Coupon code\"]");
        public By ApplyButton => By.XPath("//android.widget.TextView[@text=\"Apply\"]");
        public By PlaceOrderButton => By.XPath("//android.widget.TextView[@text=\"Place Order\"]");
    }
}
