using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SATJapanMobApplication.Pages.Base;
using OpenQA.Selenium.Appium.Android;

namespace SATJapanMobApplication.Pages.Search.Sort
{
    public partial class SortPage:BasePage
    {
        public SortPage(AndroidDriver driver):base(driver) { }
        public By SearchMenu => MobileBy.AccessibilityId("Search");
        public By SortMenu => MobileBy.XPath("//android.widget.TextView[@text=\"Sort\"]");
        public By SortBy => MobileBy.XPath($"//android.view.ViewGroup[@content-desc=\"{SortByData}\"]");
    }


}