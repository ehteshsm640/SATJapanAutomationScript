using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Pages.Search.Sort
{
    public partial class SortPage
    {
        public void FillSortPage()
        {
            Click(SearchMenu, nameof(SearchMenu));
            Click(SortMenu, nameof(SortMenu));
            Click(SortBy, nameof(SortBy));
           
        }

        }
}
