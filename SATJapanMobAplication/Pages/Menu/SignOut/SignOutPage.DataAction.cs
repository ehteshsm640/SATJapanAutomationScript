using SATJapanMobApplication.Configuration;
using SATJapanMobApplication.Utilities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.SignOut
{
    public partial class SignOutPage
    {
        public string Workbook = ConfigManager.GetSATJapanExcelPath();
        public static string SignOutSheetname = "SignOut";
        ExcelHelper excel;
    }
}
