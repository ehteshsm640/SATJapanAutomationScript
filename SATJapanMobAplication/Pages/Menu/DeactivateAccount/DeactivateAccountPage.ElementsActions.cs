using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SATJapanMobApplication.Pages.Menu.DeactivateAccount
{
    public partial class DeactivateAccountPage
    {
        public void FillDeactivateAccountPage()
        {
            Click(Menu,nameof(Menu));
            Click(ManageYourAccountMenu,nameof(ManageYourAccountMenu));
          
            Click(DeactivateAccountMenu,nameof(DeactivateAccountMenu));
            EnterText(ExplainReason,ExplainReasonData);
            Click(DeleteMyAccount, nameof(DeleteMyAccount));
            Click(ConfirmButton, nameof(ConfirmButton));

        }
        public bool Validatetext()
        {
            if (driver.FindElement(ValidateText).Displayed)
            return true;
            else return false;
        }
    }
}
