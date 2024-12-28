using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.UpdateProfileInformation
{
    public partial class UpdateProfileInformationPage
    {
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By UpdateProfileInformationMenu => By.XPath("//android.widget.TextView[@text=\"Update Profile Information\"]");
    }
}
