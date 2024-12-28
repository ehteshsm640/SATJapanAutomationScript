using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.LoginSignUp
{
    public partial class LoginSignUpPage
    {
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By LoginSignUpMenu => By.XPath("//android.widget.TextView[@text=\"Log in or Sign Up\"]");
        public By ContinuewithGoogleMenu => By.XPath("//android.widget.TextView[@text=\"Continue with Google\"]");
        public By Email => By.XPath("//android.widget.EditText[@text=\"Email\"]");
        public By ContinueButton => By.XPath("//android.widget.TextView[@text=\"Continue\"]");
        public By TermsandConditions => By.XPath("//android.widget.TextView[@text=\" Terms and Conditions \"]");
        public By PrivacyNotice => By.XPath("//android.widget.TextView[@text=\" Privacy Notice\"]");
        public By Name => By.XPath("//android.widget.EditText[@text=\"Name\"]");
        public By Password => By.XPath("//android.widget.EditText[@text=\"Password\"]");
        public By ConfirmPassword => By.XPath("//android.widget.EditText[@text=\"Confirm Password\"]");
        public By ForgotPassword => By.XPath("//android.widget.TextView[@text=\"Forgot Password?\"]");
        public By SignUpButton => By.XPath("//android.widget.TextView[@text=\"Sign Up\"]");
        public By LoginButton => By.XPath("//android.widget.TextView[@text=\"Log In\"]");
        public By LoginorSignUp => By.XPath("//android.widget.TextView[contains(@text,\"Welcome\")]");
        public By ValidateLoginSignUp => By.XPath($"//android.widget.TextView[contains(@text,'{NameData}')]");
    }
}
