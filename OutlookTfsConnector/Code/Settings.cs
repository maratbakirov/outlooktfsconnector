using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutlookTfsConnector;

namespace OutlookTfsConnector
{
    public class TfsConfigurationItem : ICloneable
    {
        public string TfsUrl { get; set; }
        public string TfsProject { get; set; } 
        public string TfsUserName { get; set; }
        public string TfsUserToken { get; set; }

        public TfsConfigurationItem(
            string TfsUrl = "",
            string TfsProject = "",
            string TfsUserName = "",
            string TfsUserToken = ""
            )
        {
            this.TfsUrl = TfsUrl;
            this.TfsProject = TfsProject;
            this.TfsUserName = TfsUserName;
            this.TfsUserToken = TfsUserToken;
        }

        public object Clone()
        {
            var result = new TfsConfigurationItem();
            result.TfsUrl = this.TfsUrl;
            result.TfsProject = this.TfsProject;
            result.TfsUserName = this.TfsUserName;
            result.TfsUserToken = this.TfsUserToken;
            return result;
        }
    }
    public class Settings
    {
        private const string RegisrtyPath = @"Software\Microsoft\Office\Outlook\AddinsCustomData\OutlookTfsConnector";
        public string RegexToParseEmailSubjects = "";
        public List<TfsConfigurationItem> TfsConfigurations = new List<TfsConfigurationItem>();

        public void Load()
        {
            //TODO: load from registry
            //TfsConfigurations[0].TfsUrl = ConfigurationManager.AppSettings["TFS_URL"];
            //TfsConfigurations[0].TfsProject = ConfigurationManager.AppSettings["TFS_PROJECT"];
            //TfsConfigurations[0].TfsUserName = ConfigurationManager.AppSettings["TFS_USERNAME"];
            //TfsConfigurations[0].TfsUserToken = ConfigurationManager.AppSettings["TFS_USERTOKEN"];

            try
            {

                RegistryKey key = Registry.CurrentUser.OpenSubKey(RegisrtyPath);
                RegexToParseEmailSubjects = (string)key.GetValue("RegexToParseEmailSubjects", "");
                var TfsConfigurationsCount = (int)key.GetValue("TfsConfigurationsCount");
                for (int idx = 0; idx < TfsConfigurationsCount; idx++)
                {
                    var tfsUserToken = "";
                    try
                    {
                        tfsUserToken = ((string)key.GetValue("TfsConfiguration" + idx + ".TfsUserToken")).Decrypt();
                    }
                    catch(Exception ex)
                    {
                        //TODO: log exception
                    }
                    TfsConfigurations.Add(new TfsConfigurationItem(
                            (string)key.GetValue("TfsConfiguration" + idx + ".TfsUrl"),
                            (string)key.GetValue("TfsConfiguration" + idx + ".TfsProject"),
                            (string)key.GetValue("TfsConfiguration" + idx + ".TfsUserName"),
                            tfsUserToken
                        )); ;
                }
                if (!FixAllUrls())
                {
                    Save();
                }
            }
            catch (Exception ex)
            {
                // todo: log cannot read data from registry
            }

        }

        public void Save()
        {
            FixAllUrls();
            //TODO: save to registry
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegisrtyPath);
            key.SetValue("RegexToParseEmailSubjects", RegexToParseEmailSubjects);
            key.SetValue("TfsConfigurationsCount", TfsConfigurations.Count);
            for (int idx =0; idx<TfsConfigurations.Count; idx++)
            {
                key.SetValue("TfsConfiguration" + idx + ".TfsUrl", TfsConfigurations[idx].TfsUrl);
                key.SetValue("TfsConfiguration" + idx + ".TfsProject", TfsConfigurations[idx].TfsProject);
                key.SetValue("TfsConfiguration" + idx + ".TfsUserName", TfsConfigurations[idx].TfsUserName);
                key.SetValue("TfsConfiguration" + idx + ".TfsUserToken", TfsConfigurations[idx].TfsUserToken.Encrypt());
         
            }
        }


        public bool FixAllUrls()
        {
            bool result = true;
            foreach(var configuraiton in TfsConfigurations)
            {
                if (!configuraiton.TfsUrl.EndsWith("/"))
                {
                    configuraiton.TfsUrl = configuraiton.TfsUrl + "/";
                    result = false;
                }
            }

            return result;
        }
    }
}
