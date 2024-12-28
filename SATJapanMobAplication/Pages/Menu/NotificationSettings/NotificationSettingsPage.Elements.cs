using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SATJapanMobApplication.Pages.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.NotificationSettings
{
    public partial class NotificationSettingsPage:BasePage
    {
        public NotificationSettingsPage(AndroidDriver driver) : base(driver)
        { }
        public By Menu => By.XPath("//android.widget.TextView[@text=\"Menu\"]");
        public By ManageYourAccountMenu => By.XPath("//android.widget.TextView[@text=\"Manage Your Account\"]");
        public By NotificationSettingsMenu => By.XPath("//android.widget.TextView[@text=\"Notification Settings\"]");
        public By AllowAllNotificationsCheckbox => By.XPath("//android.widget.TextView[@text=\"Allow All Notifications\"]/../android.widget.Switch");
        public By SMSNotificationsCheckbox => By.XPath("//android.widget.TextView[@text=\"SMS Notification\"]/../android.widget.Switch[1]");
        public By EmailNotificationCheckbox => By.XPath("//android.widget.TextView[@text=\"Email Notification\"]/../android.widget.Switch[2]");
    }
    }

