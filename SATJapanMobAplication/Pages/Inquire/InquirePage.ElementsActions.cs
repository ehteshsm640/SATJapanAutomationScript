using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;

namespace SATJapanMobApplication.Pages.Inquire
{
    public partial class InquirePage:BasePage
    {
        public InquirePage(AndroidDriver driver) : base(driver)
        {
           
        }
        public void FillInquirePage()
        {
            Click(InquireMenu);
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
            if(!string.IsNullOrEmpty(MarineInsuranceFeeYesFlagData))
                Click(MarineInsuranceFeeYesFlag);
            if (!string.IsNullOrEmpty(PreExportInspectionYesFlagData))
                Click(PreExportInspectionYesFlag);
            EnterText(Name, NameData);
            if (!string.IsNullOrEmpty(CountryNameSearchData)) 
            {
                Click(ContouryCodeButton);
                EnterText(ContouryCodeSearch, CountryNameSearchData);
                Click(SelectContouryCode);
             }
            EnterText(PhoneNo, PhoneNoData);
            ScrollToElement(nameof(Message));
            Clear_EnterText(Email,EmailData);
            EnterText(Message, MessageData);
            Click(SubmitButton);
        }
    }
}
