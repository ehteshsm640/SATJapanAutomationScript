using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;

namespace SATJapanMobApplication.Pages.Buy_Now
{
    public partial class BuyNowPage : BasePage
    {
        public BuyNowPage(AndroidDriver driver) : base(driver) { }


        public void FillBuyNowPage()
        {
            Click(BuyNowMenu);
            Click(DestinationCountry);
            EnterText(DestinationCountrySearch, DestinationCountrySearchData);
            Thread.Sleep(1000);
            Click(DestinationCountrySearchResult);
            if (!string.IsNullOrEmpty(DestinationPortSearchData))
            {
                Click(DestinationPort);
                EnterText(DestinationPortSearch, DestinationPortSearchData);
                Click(DestinationPortSearchResult);
            }

            if (string.Equals(MarineInsuranceFeeFlagData, "No", StringComparison.OrdinalIgnoreCase))
                Click(MarineInsuranceFeeNoFlag);
            else if (string.Equals(MarineInsuranceFeeFlagData, "Yes", StringComparison.OrdinalIgnoreCase))
                Click(MarineInsuranceFeeYesFlag);

            if (string.Equals(PreExportInspectionFlagData, "No", StringComparison.OrdinalIgnoreCase))
                Click(PreExportInspectionNoFlag);
            else if (string.Equals(PreExportInspectionFlagData, "Yes", StringComparison.OrdinalIgnoreCase))
                Click(PreExportInspectionYesFlag);

            if (string.Equals(SATWarrantyFlagData, "No", StringComparison.OrdinalIgnoreCase))
                Click(SATWarrantyNoFlag);
            else if (string.Equals(SATWarrantyFlagData, "Yes", StringComparison.OrdinalIgnoreCase))
                Click(SATWarrantyYesFlag);
            if (!string.IsNullOrEmpty(WarrantyNoticeButtonData))
            {
                if (string.Equals(WarrantyNoticeButtonData, "No", StringComparison.OrdinalIgnoreCase))
                    Click(WarrantyNoticeNoButton);
                else if (string.Equals(WarrantyNoticeButtonData, "Yes", StringComparison.OrdinalIgnoreCase)) Click(WarrantyNoticeYesButton);
            }

           if (!string.IsNullOrEmpty(AcceptedCountrySearchData))
            {
                Click(AcceptedCurrencies);
                EnterText(AcceptedCurrenciesSearch, AcceptedCountrySearchData);
                Click(AcceptedCurrenciesSearchResult);
            }

            Click(ContinueButton);
            Click(AddAddressButton);

            EnterText(Name, NameData);

            if (!string.IsNullOrEmpty(PhoneContouryCodeSearchData))
            {
                Click(PhoneContouryCodeButton);
                EnterText(PhoneContouryCodeSearch, PhoneContouryCodeSearchData);
                Click(PhoneSelectContouryCode);
            }
            EnterText(Email, EmailData);
            EnterText(PhoneNo, PhoneNoData);
            EnterText(Address, AddressData);

            if (!string.IsNullOrEmpty(AddressCountrySearchData))
            {
                Click(AddressCountryButton);
                EnterText(AddressContourySearch, AddressCountrySearchData);
                Click(AddressContourySearchResult);
            }

            Thread.Sleep(2000);
            Click(SubmitButton);
            Click(ContinueButton);
            Thread.Sleep(1000);
            if (!string.IsNullOrEmpty(CouponCodeData))
            {
                EnterText(CouponCode, CouponCodeData);
                Click(ApplyButton);
            }
            Click(PlaceOrderButton);
        }

    }
}
