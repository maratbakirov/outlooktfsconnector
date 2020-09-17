using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTfsConnector
{
    public static class SavedOptions

    {
        public static Dictionary<string, string> settings = new Dictionary<string, string>();
        private const string RegistryPath = @"Software\Microsoft\Office\Outlook\AddinsCustomData\OutlookTfsConnector\SavedOptions";
        private const string RegistryKey = @"";
        public static void SaveToRegistry()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(RegistryPath);
                foreach (var key in settings.Keys)
                {
                    registryKey.SetValue(key, settings[key]);
                }
            }
            catch (Exception ex)
            {
                //todo:logging
            }

        }
        public static void LoadFromRegistry()
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(RegistryPath);
                if (registryKey != null)
                {
                    foreach (var key in registryKey.GetValueNames())
                    {
                        settings[key] = registryKey.GetValue(key).ToString();
                    }
                }
            }
            catch(Exception ex)
            { 
                //todo:logging
            }
            


        }
    }
}
