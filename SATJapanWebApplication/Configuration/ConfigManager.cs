using Newtonsoft.Json;
using SATJapanWebApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SATJapanWebApplication.Configuration
{
    public static class ConfigManager
    {
        public  const string AutomationConfigSetting= "AutomationConfigSetting.json";
        public  const string ApplicationConfigSetting = "ApplicationConfigSetting.json";
        public  const string ExcelConfigSetting = "ExcelConfigSetting.json";

        // Define the path to the AutomationConfigSetting.json in the root directory
        public static string AutomationConfigSettingPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AutomationConfigSetting);
        public static string ApplicationConfigSettingPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ApplicationConfigSetting);
        public static string ExcelConfigSettingPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ExcelConfigSetting);

        public static AutomationConfigSetting LoadAutomationConfigSetting()
        {
            if (File.Exists(AutomationConfigSettingPath))
            {
                string jsonData = File.ReadAllText(AutomationConfigSettingPath);
                return JsonConvert.DeserializeObject<AutomationConfigSetting>(jsonData);  // Correct usage of JsonConvert
            }
            else
            {
                throw new FileNotFoundException($"Configuration file not found: {AutomationConfigSettingPath}");
            }
        }


        public static ApplicationConfigSetting LoadApplicationConfigSetting()
        {
            if (File.Exists(ApplicationConfigSettingPath))
            {
                string jsonData = File.ReadAllText(ApplicationConfigSettingPath);
                return JsonConvert.DeserializeObject<ApplicationConfigSetting>(jsonData);  // Correct usage of JsonConvert
            }
            else
            {
                throw new FileNotFoundException($"Configuration file not found: {ApplicationConfigSettingPath}");
            }
        }
        public static ExcelConfigSetting LoadExcelConfig()
        {
            if (File.Exists(ExcelConfigSettingPath))
            {
                string jsonData = File.ReadAllText(ExcelConfigSettingPath);
                return JsonConvert.DeserializeObject<ExcelConfigSetting>(jsonData);
            }
            else
            {
                throw new FileNotFoundException($"Configuration file not found: {ExcelConfigSettingPath}");
            }
        }

        // Function to get the Excel path for SATJapan
        public static string GetSATJapanExcelPath()
        {
            var config = LoadExcelConfig();
            return config.SATJapanWeb;
        }
    }
}
