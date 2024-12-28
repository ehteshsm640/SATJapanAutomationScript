using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Reserve
{
    public partial class ReservePage
    {
        public By ReserveMenu => By.XPath("//android.widget.TextView[@text='Reserve']");
        public By Reserve99Menu => By.XPath("//android.widget.TextView[@text='Reserve for $99']");
        public By Name => By.XPath("//android.widget.EditText[@text='Name']");
        public By ContouryCodeButton => By.XPath("//android.widget.TextView[@text='🇵🇰']");
        public By ContouryCodeSearch => By.XPath("//android.widget.EditText[@resource-id='text-input-country-filter']");
        public By SelectContouryCode => By.XPath($"//android.view.ViewGroup[contains(@content-desc,'{CountryNameSearchData}')]");

        //phone No
        public By PhoneNo => By.XPath("//android.widget.EditText[@text='Phone Number']");
        public By Email => By.XPath("//android.widget.EditText[@text='Email']");
    }
}
