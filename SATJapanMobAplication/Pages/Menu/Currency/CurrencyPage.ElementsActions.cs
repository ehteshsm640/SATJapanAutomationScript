using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Menu.Currency
{
    public partial class CurrencyPage
    {
        public void FillCurrencyPage()
        {
            Click(Menu, nameof(Menu));
            Click(CurrencyMenu, nameof(CurrencyMenu));
            EnterText(SearchCurrency, SearchCurrencyData);
            Click(SelectCurrency, nameof(SelectCurrency));

        }
    }
}
