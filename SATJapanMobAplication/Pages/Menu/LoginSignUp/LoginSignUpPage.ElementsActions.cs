using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.LoginSignUp
{
    public partial class LoginSignUpPage:BasePage
    {
        public LoginSignUpPage(AndroidDriver driver) : base(driver) { }
        public void FillLoginSignUpPage()
        {
            Click(Menu);
            Click(LoginSignUpMenu);

            EnterText(Email,EmailData);
            Click(ContinueButton);

            //if (!driver.FindElement(LoginorSignUp).Displayed)
           try
            {
                EnterText(Name, NameData);
                EnterText(Password, PasswordData);
                EnterText(ConfirmPassword, ConfirmPasswordData);
                Click(SignUpButton);
            }
            catch { }
            //need to write proper logic
            EnterText(Password, PasswordData);
            Click(LoginButton);
            if (!driver.FindElement(ValidateLoginSignUp).Displayed)
            Assert.Fail();
        }
        }
}
