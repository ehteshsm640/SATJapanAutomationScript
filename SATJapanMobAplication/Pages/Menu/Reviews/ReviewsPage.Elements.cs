using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Reviews
{
    public partial class ReviewsPage:BasePage
    {
        public ReviewsPage(AndroidDriver driver) : base(driver) { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By ReviewsMenu => By.XPath("//android.widget.TextView[@text=\"Reviews\"]");
    }
}
