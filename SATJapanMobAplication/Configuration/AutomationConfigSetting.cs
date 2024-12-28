using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Configuration
{
    public class AutomationConfigSetting
    {
        public int ImplicitWait { get; set; }
        public int ExplicitWait { get; set; }
        public int PageTimeout { get; set; }
    }
}
