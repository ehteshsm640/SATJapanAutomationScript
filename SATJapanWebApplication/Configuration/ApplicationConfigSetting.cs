using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanWebApplication.Configuration
{
    public  class ApplicationConfigSetting
    {
        public ApplicationSettings ApplicationSettings { get; set; }
    }
    public class ApplicationSettings
    {
        public string Url { get; set; }
        public string Browser { get; set; }
        public bool Headless { get; set; }
    }
}
