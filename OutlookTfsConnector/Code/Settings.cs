﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutlookTfsConnector;
using Microsoft.TeamFoundation.Common;

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
        private const string RegistryPath = @"Software\Microsoft\Office\Outlook\AddinsCustomData\OutlookTfsConnector";
        public string RegexToParseEmailSubjects = "";
        public List<TfsConfigurationItem> TfsConfigurations = new List<TfsConfigurationItem>();

        public  Task  Load()
        {
            return Task.Run(() =>
            {
                try
                {

                    RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath);
                    if (key != null)
                    {
                        RegexToParseEmailSubjects = (string)key.GetValue("RegexToParseEmailSubjects", "");
                    }
                    if (string.IsNullOrWhiteSpace(RegexToParseEmailSubjects))
                    {
                        RegexToParseEmailSubjects = @"#[\d]+";
                    }
                    var TfsConfigurationsCount = (int)key.GetValue("TfsConfigurationsCount");
                    for (int idx = 0; idx < TfsConfigurationsCount; idx++)
                    {
                        var tfsUserToken = "";
                        try
                        {
                            tfsUserToken = ((string)key.GetValue("TfsConfiguration" + idx + ".TfsUserToken")).Decrypt();
                        }
                        catch (Exception ex)
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
                    //return Task.FromException<string>(ex);
                    // todo: log cannot read data from registry
                }
                //return Task.CompletedTask;
            });
        }

        public void Save()
        {
            FixAllUrls();
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath);
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
