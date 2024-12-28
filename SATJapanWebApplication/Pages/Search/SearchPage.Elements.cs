using OpenQA.Selenium;
using SATJapanWebApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanWebApplication.Pages.Search
{
    public partial class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver):base(driver) { }

        public By Make => By.Id("MakeItem");
        public By MakeSearch => By.XPath("//input[@placeholder='Search Make']");
        public By SelectMake => By.XPath($"//li[contains(text(),'{MakeData}')]");
        public By Model => By.Id("ModalItem");
        public By ModelSearch => By.XPath("//input[@placeholder='Search Model']");
        public By SelectModel => By.XPath($"//li[contains(text(),'{ModelData}')]");
        public By Type => By.Id("type_item");
        public By TypeSearch => By.XPath("//input[@placeholder='Search Type']");
        public By SelectType => By.XPath($"//li[contains(text(),'{TypeData}')]");
        public By Steering => By.Id("steering_item");
        public By SteeringSearch => By.XPath("//input[@placeholder='Search Steering']");
        public By SelectSteering => By.XPath($"//li[contains(text(),'{SteeringData}')]");
        public By SelectSteeringTest1 => By.XPath($"//li[contains(text(),'{SteeringData}')]");
    }
}   
