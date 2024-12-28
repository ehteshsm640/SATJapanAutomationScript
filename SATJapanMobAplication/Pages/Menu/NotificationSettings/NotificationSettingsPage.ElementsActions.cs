using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.NotificationSettings
{
    public partial class NotificationSettingsPage
    {
        public void FillNotificationSettingsPage()
        {
            Click(Menu, nameof(Menu));
            Click(ManageYourAccountMenu, nameof(ManageYourAccountMenu));
            Click(NotificationSettingsMenu, nameof(NotificationSettingsMenu));
            if(!String.IsNullOrEmpty(AllowAllNotificationsCheckboxData)) Click(AllowAllNotificationsCheckbox, nameof(AllowAllNotificationsCheckbox));
            if(!String.IsNullOrEmpty(SMSNotificationsCheckboxData)) Click(SMSNotificationsCheckbox, nameof(SMSNotificationsCheckbox));
            if(!String.IsNullOrEmpty(EmailNotificationCheckboxData)) Click(EmailNotificationCheckbox, nameof(EmailNotificationCheckbox));

        }
    }
}

