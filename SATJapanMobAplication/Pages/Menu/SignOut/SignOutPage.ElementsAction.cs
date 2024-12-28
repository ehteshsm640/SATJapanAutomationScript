using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.SignOut
{
    public partial class SignOutPage
    {
        public void FillSignOutPage()
        {
            Click(Menu, nameof(Menu));
            Click(ManageYourAccountMenu, nameof(ManageYourAccountMenu));

            Click(SignOutMenu, nameof(SignOutMenu));
            
            Click(SignOutButton, nameof(SignOutButton));
           
        }
        }
}
