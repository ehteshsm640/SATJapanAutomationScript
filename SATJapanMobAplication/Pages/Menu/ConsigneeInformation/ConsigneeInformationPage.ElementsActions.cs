using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.ConsigneeInformation
{
    public partial class ConsigneeInformationPage
    {
        public void FillConsigneeInformation()
        {
            Click(Menu);
            Click(ManageYourAccountMenu);
            Click(ConsigneeInformationMenu);
            EnterText(Name, NameData);
            if (!string.IsNullOrEmpty(PhoneCountryNameSearchData))
            {
                Click(ContouryCodeButton);
                EnterText(PhoneContouryCodeSearch, PhoneCountryNameSearchData);
                Click(SelectPhoneContouryCode);
            }
            EnterText(PhoneNo, PhoneNoData);
            if (!string.IsNullOrEmpty(CountryNameData))
            {
                Click(Country);
                EnterText(Search, CountryNameData);
                Click(SelectCountryName);
            }
            EnterText(State, StateData);
            EnterText(City, CityData);
            EnterText(Email, EmailData);
            EnterText(Address,AddressData);
            Click(UpdateInformationButton);
        }
    }
}
