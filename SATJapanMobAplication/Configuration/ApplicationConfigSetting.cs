using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanMobApplication.Configuration
{
    public class ApplicationConfigSetting
    {
        public string AppiumHost { get; set; }
        public string PlatformName { get; set; }
        public string DeviceName { get; set; }
        public string AppPackage { get; set; }
        public string AppActivity { get; set; }
        public bool NoReset { get; set; }
        public string udid { get; set; }
    }
}
